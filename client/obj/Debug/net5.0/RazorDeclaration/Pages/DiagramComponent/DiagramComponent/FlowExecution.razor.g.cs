// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Testauth.Client.Pages.DiagramComponent.DiagramComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\RadZenstock\authentication\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\RadZenstock\authentication\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\RadZenstock\authentication\client\_Imports.razor"
using Testauth.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\RadZenstock\authentication\client\_Imports.razor"
using Testauth.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\RadZenstock\authentication\client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\RadZenstock\authentication\client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\RadZenstock\authentication\client\Pages\DiagramComponent\DiagramComponent\FlowExecution.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\RadZenstock\authentication\client\Pages\DiagramComponent\DiagramComponent\FlowExecution.razor"
using Syncfusion.Blazor.Diagram;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\RadZenstock\authentication\client\Pages\DiagramComponent\DiagramComponent\FlowExecution.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/diagramcomponent/flow-execution")]
    public partial class FlowExecution : SampleBaseComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "E:\RadZenstock\authentication\client\Pages\DiagramComponent\DiagramComponent\FlowExecution.razor"
 
    int connectorCount;
    string currentButton;
    private string stringChecked = "UnhighlightAll";
    List<Connector> highLightedConnector = new List<Connector>();
    List<Node> highLightedNode = new List<Node>();
    List<Connector> reachableConnectors = new List<Connector>();
    SnapSettings snapSettings;
    SnapConstraints Constraints = SnapConstraints.None;

    // Reference to diagram
    SfDiagramComponent Diagram;

    // Defines diagram's nodes collection
    public DiagramObjectCollection<Node> NodeCollection { get; set; }

    // Defines diagram's connector collection
    public DiagramObjectCollection<Connector> ConnectorCollection { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await Task.Delay(500);
            Diagram.Select(new ObservableCollection<IDiagramObject>() { Diagram.Nodes[2] });
        }
    }
    /// <summary>
    /// Initializing the objects
    /// </summary>
    protected override void OnInitialized()
    {
        InitDiagramModel();
    }
    private async void OnSelectionChanged(SelectionChangeEventArgs args)
    {
        if (args.State == EventState.Changed)
            await ApplyChanges(currentButton);
    }
    private void InitDiagramModel()
    {
        NodeCollection = new DiagramObjectCollection<Node>();
        ConnectorCollection = new DiagramObjectCollection<Connector>();

        CreateNode("node1", 100, 125, FlowShapes.Terminator, "Begin");
        CreateNode("node2", 300, 125, FlowShapes.Process, "Specify collection");
        CreateNode("node3", 500, 125, FlowShapes.Decision, "Particulars \n required?");
        CreateNode("node4", 730, 125, FlowShapes.Process, "Specify particulars");
        CreateNode("node5", 500, 225, FlowShapes.Process, "Design collection");
        CreateNode("node6", 500, 320, FlowShapes.Process, "Cluster of events");
        CreateNode("node7", 500, 420, FlowShapes.Process, "Start the process");
        CreateNode("node8", 730, 320, FlowShapes.Process, "Record and analyze \n results");
        CreateNode("node9", 730, 420, FlowShapes.Terminator, "End");

        OrthogonalSegment segment1 = new OrthogonalSegment()
        {
            Type = Segments.Orthogonal,
            Length = 75,
            Direction = Direction.Bottom
        };

        CreateConnector("node1", "node2");
        CreateConnector("node2", "node3");
        CreateConnector("node3", "node4", "Yes");
        CreateConnector("node3", "node5", "No");
        CreateConnector("node5", "node6");
        CreateConnector("node6", "node7");
        CreateConnector("node8", "node6");
        CreateConnector("node7", "node9");
        CreateConnector("node4", "node5", default(string), segment1);
    }

    private void CreateNode(string id, double x, double y, FlowShapes shape, string label)
    {
        ShapeAnnotation annotation = new ShapeAnnotation() { Content = label };

        Node diagramNode = new Node()
        {
            ID = id,
            OffsetX = x,
            OffsetY = y,
            Width = 150,
            Height = 50,
            Shape = new FlowShape() { Type = Syncfusion.Blazor.Diagram.Shapes.Flow, Shape = shape },
            Annotations = new DiagramObjectCollection<ShapeAnnotation>() { annotation },
            Style = new ShapeStyle() { Fill = "#FBF6E1", StrokeColor = "#E8DFB6", StrokeWidth = 2 }
        };
        if (id == "node3")
        {
            diagramNode.Height = 60;
        }
        NodeCollection.Add(diagramNode);
    }

    private void CreateConnector(string sourceId, string targetId, string label = default(string), OrthogonalSegment segment = null)
    {
        Connector diagramConnector = new Connector()
        {
            ID = string.Format("connector{0}", ++connectorCount),
            SourceID = sourceId,
            TargetID = targetId,
            Style = new ShapeStyle() { StrokeWidth = 2, StrokeColor = "#8D8D8D" },
            TargetDecorator = new Decorator()
            {
                Style = new ShapeStyle() { StrokeColor = "#8D8D8D", Fill = "#8D8D8D" }
            }
        };

        if (label != default(string))
        {
            var annotation = new PathAnnotation()
            {
                Content = label,
                Style = new TextShapeStyle()
                {
                    Fill = "white"
                }
            };
            diagramConnector.Annotations = new DiagramObjectCollection<PathAnnotation>() { annotation };
        }

        if (segment != null)
        {
            diagramConnector.Type = Segments.Orthogonal;
            diagramConnector.Segments = new DiagramObjectCollection<ConnectorSegment>() { segment };
        }

        ConnectorCollection.Add(diagramConnector);
    }

    private async void OnCheckedItemChange(Syncfusion.Blazor.Buttons.ChangeArgs<string> args)
    {
        currentButton = args.Value.ToString();
        await ApplyChanges(currentButton);
    }

    public async Task ApplyChanges(string selectedButton)
    {
        UnHighLight();
        switch (selectedButton)
        {
            case "LinksInto":
                LinkedConnector(false);
                break;
            case "LinksOutOf":
                LinkedConnector(true);
                break;
            case "LinksConnected":
                LinkedConnector(false);
                LinkedConnector(true);
                break;
            case "NodesInto":
                LinkedNode(false);
                break;
            case "NodesOutOf":
                LinkedNode(true);
                break;
            case "NodesConnected":
                LinkedNode(false);
                LinkedNode(true);
                break;
            case "NodesReachable":
                await ChildrenFlow();
                break;
        }
    }

    public void LinkedConnector(bool isOutEdge)
    {
        if (Diagram.SelectedItems.Nodes.Count > 0)
        {
            Node nodeId = this.Diagram.SelectedItems.Nodes[0];
            List<string> inedges = nodeId.InEdges;
            List<string> outedge = nodeId.OutEdges;
            List<string> edges = new List<string>();
            if (isOutEdge)
            {
                foreach (string s in outedge)
                {
                    edges.Add(s);
                }
            }
            else
            {
                foreach (string s in inedges)
                {
                    edges.Add(s);
                }
            }

            foreach (string edge in edges)
            {
                IDiagramObject obj = Diagram.GetObject(edge) as IDiagramObject;
                Connector connector = obj as Connector;
                highLightedConnector.Add(connector);
                connector.Style.StrokeColor = "#1413F8";
                connector.TargetDecorator.Style.StrokeColor = "#1413F8";
                connector.TargetDecorator.Style.Fill = "#1413F8";
            }
        }
    }

    public void LinkedNode(bool isOutEdge)
    {
        if (Diagram.SelectedItems.Nodes.Count > 0)
        {
            Node nodeId = this.Diagram.SelectedItems.Nodes[0];
            List<string> inedges = nodeId.InEdges;
            List<string> outedge = nodeId.OutEdges;
            List<string> edges = new List<string>();
            if (!isOutEdge)
            {
                foreach (string s in inedges)
                {
                    edges.Add(s);
                }
            }
            else
            {
                foreach (string s in outedge)
                {
                    edges.Add(s);
                }
            }

            //string[] edges = await Diagram.GetEdges(nodeId, isOutEdge);
            foreach (string edge in edges)
            {
                IDiagramObject obj = Diagram.GetObject(edge) as IDiagramObject;
                Connector connector = obj as Connector;
                Node node = null;
                if (isOutEdge)
                {
                    IDiagramObject obj1 = Diagram.GetObject(connector.TargetID) as IDiagramObject;
                    Node objj = obj1 as Node;
                    node = objj;

                }
                else
                {
                    IDiagramObject obj1 = Diagram.GetObject(connector.SourceID) as IDiagramObject;
                    Node objj = obj1 as Node;
                    node = objj;

                }

                highLightedNode.Add(node);
                node.Style.StrokeColor = "#1413F8";
            }
        }
    }

    public async Task ChildrenFlow()
    {
        if (Diagram.SelectedItems.Nodes.Count > 0)
        {
            string nodeId = this.Diagram.SelectedItems.Nodes[0].ID;
            await FindReachable(nodeId);
            if (reachableConnectors.Count > 0)
            {
                foreach (Connector connector in reachableConnectors)
                {
                    highLightedConnector.Add(connector);
                    connector.Style.StrokeColor = "#1413F8";
                    connector.TargetDecorator.Style.StrokeColor = "#1413F8";
                    connector.TargetDecorator.Style.Fill = "#1413F8";
                }

                reachableConnectors.Clear();
            }
        }
    }

    public async Task<List<Connector>> FindReachable(string nodeId)
    {
        IDiagramObject node = Diagram.GetObject(nodeId) as IDiagramObject;
        Node nodes = node as Node;
        List<string> inedges = nodes.InEdges;
        List<string> outedge = nodes.OutEdges;
        List<string> edges = new List<string>();
        foreach (string s in outedge)
        {
            edges.Add(s);
        }

        foreach (string edge in edges)
        {

            IDiagramObject obj = Diagram.GetObject(edge) as IDiagramObject;
            Connector connector = obj as Connector;
            if (reachableConnectors.Contains(connector))
            {
                continue;
            }

            if (connector.Annotations == null || connector.Annotations.Count == 0 || connector.Annotations[0].Content != "No")
            {
                reachableConnectors.Add(connector);
                await FindReachable(connector.TargetID);
            }
        }
        return reachableConnectors;
    }

    public void UnHighLight()
    {
        foreach (Node node in highLightedNode)
        {
            node.Style.StrokeColor = "#E8DFB6";
        }

        foreach (Connector connector in highLightedConnector)
        {
            connector.Style.StrokeColor = "#8D8D8D";
            connector.TargetDecorator.Style.StrokeColor = "#8D8D8D";
            connector.TargetDecorator.Style.Fill = "#8D8D8D";
        }

        highLightedNode.Clear();
        highLightedConnector.Clear();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
