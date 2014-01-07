// Type: OpenQuant.Projects.UI.Items.SolutionNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects;
using OpenQuant.Shared.Compiler;
using OpenQuant.Trading;
using System;
using System.Collections;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Items
{
  internal class SolutionNode : ObjectNode
  {
    private string solutionName;
    private SolutionSettings solutionSettings;
    private RequestListNode requestListNode;
    private ScenarioNode scenarioNode;
    private ContextMenuStrip ctxRequest;

    internal RequestListNode RequestListNode
    {
      get
      {
        return this.requestListNode;
      }
    }

    public override object Object
    {
      get
      {
        return (object) this.solutionSettings;
      }
    }

    public SolutionNode(string solutionName, SolutionSettings settings, ContextMenuStrip ctxRequest, ContextMenuStrip ctxRequestList, ContextMenuStrip ctxScenario, CodeLang scenarioLang)
      : base(solutionName, 11)
    {
      this.solutionName = solutionName;
      this.solutionSettings = settings;
      this.requestListNode = new RequestListNode();
      this.scenarioNode = new ScenarioNode(scenarioLang);
      this.scenarioNode.ContextMenuStrip = ctxScenario;
      this.ctxRequest = ctxRequest;
      this.requestListNode.ContextMenuStrip = ctxRequestList;
      this.Nodes.Add((TreeNode) this.requestListNode);
      this.Nodes.Add((TreeNode) this.scenarioNode);
      foreach (MarketDataRequest request in (IEnumerable) this.solutionSettings.Requests)
        this.AddRequest(request);
      this.Connect();
    }

    private void Connect()
    {
      this.solutionSettings.Requests.Added += new OpenQuantListEventHandler<MarketDataRequest>(this.Requests_Added);
      this.solutionSettings.Requests.Removed += new OpenQuantListEventHandler<MarketDataRequest>(this.Requests_Removed);
      this.solutionSettings.Requests.Cleared += new EventHandler(this.Requests_Cleared);
    }

    public void Disconnect()
    {
      if (this.solutionSettings == null)
        return;
      this.solutionSettings.Requests.Added -= new OpenQuantListEventHandler<MarketDataRequest>(this.Requests_Added);
      this.solutionSettings.Requests.Removed -= new OpenQuantListEventHandler<MarketDataRequest>(this.Requests_Removed);
      this.solutionSettings.Requests.Cleared -= new EventHandler(this.Requests_Cleared);
    }

    private void AddRequest(MarketDataRequest request)
    {
      RequestNode requestNode = new RequestNode(request);
      requestNode.ContextMenuStrip = this.ctxRequest;
      this.requestListNode.Nodes.Add((TreeNode) requestNode);
    }

    private void Requests_Added(object sender, OpenQuantListEventArgs<MarketDataRequest> args)
    {
      this.AddRequest(args.Object);
    }

    private void Requests_Removed(object sender, OpenQuantListEventArgs<MarketDataRequest> args)
    {
      foreach (RequestNode requestNode in this.requestListNode.Nodes)
      {
        if (requestNode.Request == args.Object)
        {
          requestNode.Remove();
          break;
        }
      }
    }

    private void Requests_Cleared(object sender, EventArgs e)
    {
      this.requestListNode.Nodes.Clear();
    }
  }
}
