// Type: OpenQuant.QuantTrader.ExportToQuantTraderForm
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Projects;
using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Data;
using OpenQuant.Shared.QuantTrader;
using OpenQuant.Trading;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using SmartQuant.Testing;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.QuantTrader
{
  internal class ExportToQuantTraderForm : Form
  {
    private Solution solution;
    private IContainer components;
    private GroupBox groupBox1;
    private TreeView trvExport;
    private ImageList imgExport;
    private Label label1;
    private Button btnExport;
    private Button btnCancel;
    private SaveFileDialog dlgExportFile;

    public ExportToQuantTraderForm()
    {
      this.InitializeComponent();
      this.dlgExportFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    }

    public void Init(Solution solution)
    {
      this.solution = solution;
    }

    protected override void OnShown(EventArgs e)
    {
      this.InitExportTree();
      base.OnShown(e);
    }

    private void InitExportTree()
    {
      SolutionNode solutionNode = new SolutionNode(this.solution);
      this.trvExport.Nodes.Add((TreeNode) solutionNode);
      ReferencesNode referencesNode = new ReferencesNode();
      solutionNode.Nodes.Add((TreeNode) referencesNode);
      foreach (BuildReference reference in Global.Options.Solutions.Build.GetReferences())
      {
        if (reference.get_Type() == 2 && reference.get_Valid())
          referencesNode.Nodes.Add((TreeNode) new ReferenceNode(reference));
      }
      MarketDataNode marketDataNode = new MarketDataNode();
      solutionNode.Nodes.Add((TreeNode) marketDataNode);
      foreach (MarketDataRequest request in (IEnumerable) this.solution.SolutionSettings.Requests)
        marketDataNode.Nodes.Add((TreeNode) new MarketDataRequestNode(request));
      PropertiesNode propertiesNode1 = new PropertiesNode();
      propertiesNode1.Nodes.Add((TreeNode) new StrategyPropertyNode(new StrategyProperty("BarFactoryInput", typeof (BarFactoryInput), (object) this.solution.SolutionSettings.BarFactoryInput)));
      propertiesNode1.Nodes.Add((TreeNode) new StrategyPropertyNode(new StrategyProperty("ReportEnabled", typeof (bool), (object) (bool) (this.solution.SolutionSettings.ReportEnabled ? 1 : 0))));
      propertiesNode1.Nodes.Add((TreeNode) new StrategyPropertyNode(new StrategyProperty("TestingPeriod", typeof (TimeIntervalSize), (object) this.solution.SolutionSettings.TestingPeriod)));
      propertiesNode1.Nodes.Add((TreeNode) new StrategyPropertyNode(new StrategyProperty("Cash", typeof (double), (object) this.solution.SolutionSettings.Cash)));
      propertiesNode1.Nodes.Add((TreeNode) new StrategyPropertyNode(new StrategyProperty("StartDate", typeof (DateTime), (object) this.solution.SolutionSettings.StartDate)));
      propertiesNode1.Nodes.Add((TreeNode) new StrategyPropertyNode(new StrategyProperty("StopDate", typeof (DateTime), (object) this.solution.SolutionSettings.StopDate)));
      solutionNode.Nodes.Add((TreeNode) propertiesNode1);
      foreach (StrategyProject project in this.solution.Projects.Values)
      {
        StrategyProjectNode strategyProjectNode = new StrategyProjectNode(project);
        solutionNode.Nodes.Add((TreeNode) strategyProjectNode);
        InstrumentsNode instrumentsNode = new InstrumentsNode();
        strategyProjectNode.Nodes.Add((TreeNode) instrumentsNode);
        foreach (Instrument instrument in (IEnumerable) project.StrategySettings.Instruments)
          instrumentsNode.Nodes.Add((TreeNode) new InstrumentNode(instrument));
        PropertiesNode propertiesNode2 = new PropertiesNode();
        strategyProjectNode.Nodes.Add((TreeNode) propertiesNode2);
        foreach (StrategyProperty property in project.StrategySettings.StrategyProperties.Values)
          propertiesNode2.Nodes.Add((TreeNode) new StrategyPropertyNode(property));
      }
      solutionNode.Expand();
      foreach (TreeNode treeNode in solutionNode.GetNodes<StrategyProjectNode>(false))
        treeNode.Expand();
      this.UpdateNodeStyle((TreeNode) solutionNode);
    }

    private void trvExport_AfterCollapse(object sender, TreeViewEventArgs e)
    {
      ((ExportItemNode) e.Node).UpdateImage();
    }

    private void trvExport_AfterExpand(object sender, TreeViewEventArgs e)
    {
      ((ExportItemNode) e.Node).UpdateImage();
    }

    private void trvExport_AfterCheck(object sender, TreeViewEventArgs e)
    {
      if (e.Action != TreeViewAction.ByMouse && e.Action != TreeViewAction.ByKeyboard)
        return;
      ExportItemNode node = (ExportItemNode) e.Node;
      this.CheckChildNodes(node);
      this.CheckParentNode(node);
      this.UpdateNodeStyle(this.trvExport.Nodes[0]);
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      this.Export();
    }

    private void CheckChildNodes(ExportItemNode node)
    {
      foreach (ExportItemNode node1 in node.Nodes)
      {
        if (node.Checked)
        {
          if (node1.AutoCheckFromParent)
          {
            node1.Checked = true;
            this.CheckChildNodes(node1);
          }
        }
        else
        {
          node1.Checked = false;
          this.CheckChildNodes(node1);
        }
      }
    }

    private void CheckParentNode(ExportItemNode node)
    {
      ExportItemNode node1 = (ExportItemNode) node.Parent;
      if (node1 == null)
        return;
      if (node.Checked)
      {
        node1.Checked = true;
        this.CheckParentNode(node1);
      }
      else
      {
        if (!node.AutoUncheckParent)
          return;
        bool flag = true;
        foreach (TreeNode treeNode in node1.Nodes)
        {
          if (treeNode.Checked)
          {
            flag = false;
            break;
          }
        }
        if (!flag)
          return;
        node1.Checked = false;
        this.CheckParentNode(node1);
      }
    }

    private void UpdateNodeStyle(TreeNode node)
    {
      node.ForeColor = node.Checked ? Color.Empty : SystemColors.GrayText;
      foreach (TreeNode node1 in node.Nodes)
        this.UpdateNodeStyle(node1);
    }

    private void Export()
    {
      Tuple<Package, string[]> tuple = this.GeneratePackage();
      if (tuple.Item2.Length > 0)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, string.Join(Environment.NewLine, tuple.Item2), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        try
        {
          this.dlgExportFile.Filter = string.Format("QuantTrader Packages|*{0}|All files|*.*", (object) ".qtp");
          this.dlgExportFile.FileName = string.Format("{0}{1}", (object) this.solution.Name, (object) ".qtp");
          if (this.dlgExportFile.ShowDialog((IWin32Window) this) != DialogResult.OK)
            return;
          using (FileStream fileStream = new FileStream(this.dlgExportFile.FileName, FileMode.Create))
          {
            PackageWriter packageWriter = (PackageWriter) new ZipPackageWriter((Stream) fileStream);
            packageWriter.Write(tuple.Item1);
            packageWriter.Close();
          }
          int num2 = (int) MessageBox.Show((IWin32Window) this, "Solution successfully exported.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
          this.Close();
        }
        catch (Exception ex)
        {
          int num2 = (int) MessageBox.Show((IWin32Window) this, ((object) ex).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
    }

    private Tuple<Package, string[]> GeneratePackage()
    {
      Package package = new Package();
      List<string> list1 = new List<string>();
      try
      {
        SolutionNode solutionNode = (SolutionNode) this.trvExport.Nodes[0];
        SolutionFolder solutionFolder = package.get_Solutions().get_Item(this.solution.Name);
        byte[] rawAssembly1;
        if (this.Compile(solutionNode.Solution.ScenarioLang, solutionNode.Solution.ScenarioFile, out rawAssembly1))
          solutionFolder.get_ScenarioAssembly().set_RawAssembly(rawAssembly1);
        else
          list1.Add("Error compiling scenario.");
        foreach (ReferenceNode referenceNode in solutionNode.GetNode<ReferencesNode>().GetNodes<ReferenceNode>(true))
        {
          FileInfo fileInfo = new FileInfo(referenceNode.Reference.get_Path());
          solutionFolder.get_References().get_Item(fileInfo.Name).set_RawAssembly(File.ReadAllBytes(fileInfo.FullName));
        }
        List<Request> list2 = new List<Request>();
        foreach (MarketDataRequestNode marketDataRequestNode in solutionNode.GetNode<MarketDataNode>().GetNodes<MarketDataRequestNode>(true))
        {
          switch ((int) marketDataRequestNode.Request.get_RequestType())
          {
            case 0:
              list2.Add(new Request((DataType) 1));
              break;
            case 1:
              list2.Add(new Request((DataType) 2));
              break;
            case 2:
              list2.Add(new Request((DataType) 5));
              break;
            case 5:
              BarRequest barRequest = (BarRequest) marketDataRequestNode.Request;
              list2.Add((Request) new BarRequest(barRequest.get_BarType(), barRequest.get_BarSize()));
              break;
          }
        }
        solutionFolder.get_MarketData().set_Requests(list2.ToArray());
        List<Property> list3 = new List<Property>();
        foreach (StrategyPropertyNode strategyPropertyNode in solutionNode.GetNode<PropertiesNode>().GetNodes<StrategyPropertyNode>(true))
          list3.Add(new Property(strategyPropertyNode.Property.Name, strategyPropertyNode.Property.Type, strategyPropertyNode.Property.Value));
        solutionFolder.get_Properties().set_Properties(list3.ToArray());
        StrategyProjectNode[] nodes = solutionNode.GetNodes<StrategyProjectNode>(true);
        if (nodes.Length > 0)
        {
          foreach (StrategyProjectNode strategyProjectNode in nodes)
          {
            StrategyProject project = strategyProjectNode.Project;
            ProjectFolder projectFolder = solutionFolder.get_Projects().get_Item(project.Name);
            byte[] rawAssembly2;
            if (this.Compile(project.CodeLang, project.CodeFile, out rawAssembly2))
              projectFolder.get_StrategyAssembly().set_RawAssembly(rawAssembly2);
            else
              list1.Add(string.Format("Error compiling project {0}", (object) project.Name));
            List<string> list4 = new List<string>();
            foreach (InstrumentNode instrumentNode in strategyProjectNode.GetNode<InstrumentsNode>().GetNodes<InstrumentNode>(true))
              list4.Add(instrumentNode.Instrument.Symbol);
            projectFolder.get_Instruments().set_Symbols(list4.ToArray());
            List<Property> list5 = new List<Property>();
            foreach (StrategyPropertyNode strategyPropertyNode in strategyProjectNode.GetNode<PropertiesNode>().GetNodes<StrategyPropertyNode>(true))
              list5.Add(new Property(strategyPropertyNode.Property.Name, strategyPropertyNode.Property.Type, strategyPropertyNode.Property.Value));
            projectFolder.get_Properties().set_Properties(list5.ToArray());
          }
        }
        else
          list1.Add("You need to select at least one strategy.");
      }
      catch (Exception ex)
      {
        list1.Add(((object) ex).ToString());
      }
      return new Tuple<Package, string[]>(package, list1.ToArray());
    }

    private bool Compile(CodeLang codeLang, FileInfo codeFile, out byte[] rawAssembly)
    {
      CompilingServices compilingServices = new CompilingServices(codeLang);
      ((CompilerParameters) compilingServices.get_Parameters()).IncludeDebugInformation = false;
      foreach (BuildReference buildReference in Global.Options.Solutions.Build.GetReferences())
      {
        if (buildReference.get_Valid())
          compilingServices.AddReference(buildReference.get_Path());
      }
      compilingServices.AddFile(codeFile.FullName);
      CompilerResults compilerResults = compilingServices.Compile();
      if (compilerResults.Errors.HasErrors)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, string.Format("Cannot compile {0}", (object) codeFile.FullName), "Compiler Error(s)", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        rawAssembly = (byte[]) null;
        return false;
      }
      else
      {
        rawAssembly = File.ReadAllBytes(compilerResults.PathToAssembly);
        return true;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ExportToQuantTraderForm));
      this.groupBox1 = new GroupBox();
      this.trvExport = new TreeView();
      this.imgExport = new ImageList(this.components);
      this.label1 = new Label();
      this.btnExport = new Button();
      this.btnCancel = new Button();
      this.dlgExportFile = new SaveFileDialog();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.trvExport);
      this.groupBox1.Location = new Point(20, 46);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(332, 342);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.trvExport.CheckBoxes = true;
      this.trvExport.Dock = DockStyle.Fill;
      this.trvExport.ImageIndex = 0;
      this.trvExport.ImageList = this.imgExport;
      this.trvExport.Location = new Point(3, 16);
      this.trvExport.Name = "trvExport";
      this.trvExport.SelectedImageIndex = 0;
      this.trvExport.ShowNodeToolTips = true;
      this.trvExport.ShowRootLines = false;
      this.trvExport.Size = new Size(326, 323);
      this.trvExport.TabIndex = 0;
      this.trvExport.AfterCheck += new TreeViewEventHandler(this.trvExport_AfterCheck);
      this.trvExport.AfterCollapse += new TreeViewEventHandler(this.trvExport_AfterCollapse);
      this.trvExport.AfterExpand += new TreeViewEventHandler(this.trvExport_AfterExpand);
      this.imgExport.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgExport.ImageStream");
      this.imgExport.TransparentColor = Color.Transparent;
      this.imgExport.Images.SetKeyName(0, "folder_closed.png");
      this.imgExport.Images.SetKeyName(1, "folder_open.png");
      this.imgExport.Images.SetKeyName(2, "solution.png");
      this.imgExport.Images.SetKeyName(3, "project.png");
      this.imgExport.Images.SetKeyName(4, "instrument.png");
      this.imgExport.Images.SetKeyName(5, "market_data_request.png");
      this.imgExport.Images.SetKeyName(6, "properties.png");
      this.imgExport.Images.SetKeyName(7, "field.png");
      this.imgExport.Images.SetKeyName(8, "refrences_closed.png");
      this.imgExport.Images.SetKeyName(9, "references_open.png");
      this.imgExport.Images.SetKeyName(10, "reference.png");
      this.label1.Location = new Point(20, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(332, 31);
      this.label1.TabIndex = 1;
      this.label1.Text = "Please, select items you want to export to QuantTrader";
      this.btnExport.Location = new Point(102, 408);
      this.btnExport.Name = "btnExport";
      this.btnExport.Size = new Size(80, 24);
      this.btnExport.TabIndex = 2;
      this.btnExport.Text = "Export";
      this.btnExport.UseVisualStyleBackColor = true;
      this.btnExport.Click += new EventHandler(this.btnExport_Click);
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(192, 408);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(80, 24);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.dlgExportFile.DefaultExt = "zip";
      this.dlgExportFile.Title = "Select output file";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(374, 451);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnExport);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.groupBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ExportToQuantTraderForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Export to QuantTrader";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
