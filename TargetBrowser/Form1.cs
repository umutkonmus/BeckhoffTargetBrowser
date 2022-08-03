using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace TargetBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        TcAdsClient adsClient;
        TcAdsSymbolInfoLoader symbolLoader;
        ITcAdsSymbol currentSymbol = null;
        AdsStream _adsStream = null;
        AdsBinaryReader _binRead = null;
        int _notificationHandle = 0;
        string PLC1;
        int iPlcState; // 0=Config 1=Run
        object selectedNode;
        Timer disconnectTimer = new Timer();

        private void SetSymbolInfo(ITcAdsSymbol symbol)
        {
            currentSymbol = symbol;
            tbName.Text = symbol.Name.ToString();
            tbIndexGroup.Text = symbol.IndexGroup.ToString();
            tbIndexOffset.Text = symbol.IndexOffset.ToString();
            tbSize.Text = symbol.Size.ToString();
            tbDatatype.Text = symbol.Type;
            tbDatatypeId.Text = symbol.Datatype.ToString();
            try
            {
                if (adsClient.ReadSymbol(symbol).ToString() == "True" || adsClient.ReadSymbol(symbol).ToString() == "False")
                {
                    //booleansa
                    string val = adsClient.ReadSymbol(symbol).ToString();
                    tbValue.Enabled = false;
                    cbValue.Visible = true;
                    cbValue.Enabled = true;
                    if (val == "True") cbValue.SelectedIndex = 0; else cbValue.SelectedIndex = 1;
                }
                else
                {
                    cbValue.Visible = false;
                    tbValue.Enabled = true;
                    tbValue.Text = adsClient.ReadSymbol(symbol).ToString();
                }
            }
            catch (AdsDatatypeNotSupportedException err)
            {
                tbValue.Text = err.Message;
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to read Symbol Info. " + err.Message);
            }
        }

        private TreeNode CreateNewNode(TcAdsSymbolInfo symbol)
        {
            TreeNode node = new TreeNode(symbol.Name);

            node.Tag = symbol;
            TcAdsSymbolInfo subSymbol = symbol.FirstSubSymbol;
            while (subSymbol != null)
            {
                node.Nodes.Add(CreateNewNode(subSymbol));
                subSymbol = subSymbol.NextSymbol;
            }
            return node;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                disconnectTimer.Start();
                adsClient = new TcAdsClient();
                baglan();
            }
            catch { adsClient.Disconnect(); }
        }

        void writePlcState(int inPlcState)
        {
            if (inPlcState == 1) pbTcState.Image = TargetBrowser.Properties.Resources.tcRunImg;
            else  pbTcState.Image = TargetBrowser.Properties.Resources.tcConfigImg; 
        }

        private void baglan()
        {
            adsClient.Disconnect();
            PLC1 = tbNetId.Text;
            try
            {
                // Connect to local PLC - Runtime 1 - TwinCAT2 Port=801, TwinCAT3 Port=851
                adsClient.Connect(PLC1,851);
                adsClient.ReadState().ToString();
                if (adsClient.IsConnected) iPlcState = 1; else iPlcState = 0;
                writePlcState(iPlcState);

                symbolLoader = adsClient.CreateSymbolInfoLoader();
            }
            catch (Exception err)
            {
                adsClient.Disconnect();
                pbTcState.Image = TargetBrowser.Properties.Resources.tcConfigImg;
                iPlcState = 0;
                writePlcState(iPlcState);
            }
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                baglan();

                treeViewSymbols.Nodes.Clear();

                if (!cbFlat.Checked)
                {
                    TcAdsSymbolInfo symbol = symbolLoader.GetFirstSymbol(true);
                    while (symbol != null)
                    {
                        string[] symbols = symbol.Name.Split('.');
                        if (symbols[0] == "MAIN" || symbols[0] == "GVL")
                        {
                            treeViewSymbols.Nodes.Add(CreateNewNode(symbol));
                        }
                        symbol = symbol.NextSymbol;
                    }
                }
                else
                {
                    foreach (TcAdsSymbolInfo symbol in symbolLoader)
                    {
                        string[] symbols = symbol.Name.Split('.');
                        if (symbols[0] == "MAIN" || symbols[0] == "GVL")
                        {
                            TreeNode node = new TreeNode(symbol.Name);
                            node.Tag = symbol;
                            treeViewSymbols.Nodes.Add(node);
                        }
                    }
                }
            }
            catch { adsClient.Disconnect(); pbTcState.Image = TargetBrowser.Properties.Resources.tcConfigImg; }
        }
        
        private void btnReadSymbolInfo_Click(object sender, EventArgs e)
        {
            try
            {
                ITcAdsSymbol symbol = adsClient.ReadSymbolInfo(tbSymbolname.Text);
                if (symbol == null)
                {
                    MessageBox.Show("Symbol " + tbSymbolname.Text + " not found");
                    return;
                }
                SetSymbolInfo(symbol);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnFindSymbol_Click(object sender, EventArgs e)
        {
            try
            {
                /*ITcAdsSymbol symbol = symbolLoader.FindSymbol(tbSymbolname.Text);
                if (symbol == null)
                {
                    MessageBox.Show("Symbol " + tbSymbolname.Text + " not found");
                    return;
                }SetSymbolInfo(symbol);*/

                treeViewSymbols.Nodes.Clear();
                TcAdsSymbolInfo symbol = symbolLoader.GetFirstSymbol(true);

                while (symbol != null)
                {
                    string sWanted = tbSymbolname.Text;
                    string[] symbols = symbol.Name.Split('.');
                    foreach(string word in symbols)
                    {
                        if(word == sWanted) { treeViewSymbols.Nodes.Add(CreateNewNode(symbol)); }
                    }
                    symbol = symbol.NextSymbol;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSymbol != null)
                {
                    if (cbValue.Enabled)
                    {
                        adsClient.WriteSymbol(currentSymbol, cbValue.Text);
                    }
                    else
                    {
                        adsClient.WriteSymbol(currentSymbol, tbValue.Text);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to write Value. " + err.Message);
            }
        }

        private void treeViewSymbols_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNode = e;
            if (e.Node.Text.Length > 0)
            {
                if (e.Node.Tag is TcAdsSymbolInfo)
                {
                    SetSymbolInfo((ITcAdsSymbol)e.Node.Tag);
                }
            }
        }

        private void tbSymbolname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFindSymbol.PerformClick();
            }
        }

        private void disconnectTimer_Tick(object sender, EventArgs e)
        {
            baglan();
            if(tbDatatype.Text != "")
            {
                treeViewSymbols_AfterSelect(sender, selectedNode as TreeViewEventArgs);
            }
        }

    }
}
