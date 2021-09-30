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
#line 5 "E:\RadZenstock\authentication\client\Pages\DiagramComponent\DiagramComponent\FlowChart.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\RadZenstock\authentication\client\Pages\DiagramComponent\DiagramComponent\FlowChart.razor"
using Syncfusion.Blazor.Diagram;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\RadZenstock\authentication\client\Pages\DiagramComponent\DiagramComponent\FlowChart.razor"
using Syncfusion.Blazor.SymbolPalette;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/diagramcomponent/flowchart")]
    public partial class FlowChart : SampleBaseComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 173 "E:\RadZenstock\authentication\client\Pages\DiagramComponent\DiagramComponent\FlowChart.razor"
      
    Size SymbolPreview;
    SymbolMargin SymbolMargin = new SymbolMargin { Left = 15, Right = 15, Top = 15, Bottom = 15 };
    SfDiagramComponent DInstance;
    SfSymbolPaletteComponent PaletteInstance;
    int portCount = 0;
    int connectorCount = 0;

    //Defines Diagram's nodes collection
    DiagramObjectCollection<Node> nodes = new DiagramObjectCollection<Node>();

    //Defines Diagram's connectors collection
    DiagramObjectCollection<Connector> connectors = new DiagramObjectCollection<Connector>();

    //Define palattes collection
    DiagramObjectCollection<Palette> Palettes = new DiagramObjectCollection<Palette>();

    // Defines palette's flow-shape collection
    DiagramObjectCollection<NodeBase> Tnodes = new DiagramObjectCollection<NodeBase>();

    // Defines interval values for GridLines
    public double[] GridLineIntervals { get; set; }

    // Defines palette's connector collection
    DiagramObjectCollection<NodeBase> T2nodes = new DiagramObjectCollection<NodeBase>();
#pragma warning disable CS1998
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        PaletteInstance.DiagramInstances = new DiagramObjectCollection<SfDiagramComponent>() { };
        PaletteInstance.DiagramInstances.Add(DInstance);
    }
    protected override void OnInitialized()
    {
        GridLineIntervals = new double[] {
            1, 9, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75
        };
        InitDiagramModel();
        InitPaletteModel();
    }
    // Create Nodes and connectors for the diagram.
    private void InitDiagramModel()
    {
        CreateNode("node1", 300, 80, FlowShapes.Terminator, "Place order");
        CreateNode("node2", 300, 160, FlowShapes.Process, "Start transaction");
        CreateNode("node3", 300, 240, FlowShapes.Process, "Verification");
        CreateNode("node4", 300, 330, FlowShapes.Decision, "Credit card valid?");
        CreateNode("node5", 300, 430, FlowShapes.Decision, "Funds available?");
        CreateNode("node6", 530, 330, FlowShapes.Process, "Enter payment method");
        CreateNode("node7", 300, 530, FlowShapes.Process, "Complete transaction");
        CreateNode("node8", 110, 530, FlowShapes.Data, "Send e-mail");
        CreateNode("node9", 475, 530, FlowShapes.DirectData, "Customer \n database");
        CreateNode("node10", 300, 630, FlowShapes.Terminator, "Log transaction");
        CreateNode("node11", 480, 630, FlowShapes.Process, "Reconcile the entries");
        DiagramObjectCollection<ConnectorSegment> segment1 = new DiagramObjectCollection<ConnectorSegment>()
{
            new OrthogonalSegment
            {
                Type=Segments.Orthogonal,
                Direction = Direction.Top,
                Length=120,
            },
        };
        DiagramObjectCollection<ConnectorSegment> segment2 = new DiagramObjectCollection<ConnectorSegment>()
{
             new OrthogonalSegment
            {
                Type=Segments.Orthogonal,
                Length=100,
                Direction = Direction.Right,

            },
        };
        CreateConnector("node1", "node2");
        CreateConnector("node2", "node3");
        CreateConnector("node3", "node4");
        CreateConnector("node4", "node5", "Yes");
        CreateConnector("node4", "node6", "No");
        CreateConnector("node5", "node6", "No", segment2);
        CreateConnector("node5", "node7", "Yes");
        CreateConnector("node6", "node2", default(string), segment1);
        CreateConnector("node7", "node8");
        CreateConnector("node7", "node9");
        CreateConnector("node7", "node10");
        CreateConnector("node10", "node11", default(string), null, true);
    }
    // Create Nodes and connectors for the Palette.
    private void InitPaletteModel()
    {
        Palettes = new DiagramObjectCollection<Palette>();
        SymbolPreview = new Size();
        SymbolPreview.Width = 100;
        SymbolPreview.Height = 100;

        Tnodes = new DiagramObjectCollection<NodeBase>();
        CreatePaletteNode(FlowShapes.Terminator, "Terminator");
        CreatePaletteNode(FlowShapes.Process, "Process");
        CreatePaletteNode(FlowShapes.Decision, "Decision");
        CreatePaletteNode(FlowShapes.Document, "Document");
        CreatePaletteNode(FlowShapes.PreDefinedProcess, "Predefined Process");
        CreatePaletteNode(FlowShapes.PaperTap, "Punched Tape");
        CreatePaletteNode(FlowShapes.DirectData, "Direct Data");
        CreatePaletteNode(FlowShapes.SequentialData, "Sequential Data");
        CreatePaletteNode(FlowShapes.Sort, "Sort");
        CreatePaletteNode(FlowShapes.MultiDocument, "Multidocument");
        CreatePaletteNode(FlowShapes.Collate, "Collate");
        CreatePaletteNode(FlowShapes.SummingJunction, "Summing Junction");
        CreatePaletteNode(FlowShapes.Or, "Or");
        CreatePaletteNode(FlowShapes.InternalStorage, "Internal Storage");
        CreatePaletteNode(FlowShapes.Extract, "Extract");
        CreatePaletteNode(FlowShapes.SequentialAccessStorage, "Sequential Access Storage");
        CreatePaletteNode(FlowShapes.Annotation, "Annotation");
        CreatePaletteNode(FlowShapes.Annotation2, "Annotation2");
        CreatePaletteNode(FlowShapes.Data, "Data");
        CreatePaletteNode(FlowShapes.Card, "Card");
        CreatePaletteNode(FlowShapes.Delay, "Delay");

        T2nodes = new DiagramObjectCollection<NodeBase>();
        CreatePaletteConnector("Link1", Segments.Orthogonal, DecoratorShapes.Arrow);
        CreatePaletteConnector("Link2", Segments.Orthogonal, DecoratorShapes.None);
        CreatePaletteConnector("Link3", Segments.Straight, DecoratorShapes.Arrow);
        CreatePaletteConnector("Link4", Segments.Straight, DecoratorShapes.None);
        CreatePaletteConnector("Link5", Segments.Bezier, DecoratorShapes.None);

        Palettes = new DiagramObjectCollection<Palette>()
        {
                #pragma warning disable BL0005
                new Palette(){Symbols =Tnodes,Title="Flow Shapes",Id="Flow Shapes" },
                #pragma warning disable BL0005
                new Palette(){Symbols =T2nodes,Title="Connectors" ,Expanded = true},

        };
    }
    // Method is used to create a node for the palette.
    private void CreatePaletteNode(FlowShapes flowShape, string id)
    {
        Node diagramNode = new Node()
        {
            ID = id,
            Shape = new FlowShape() { Type = Syncfusion.Blazor.Diagram.Shapes.Flow, Shape = flowShape },
            Style = new ShapeStyle() { StrokeColor = "#757575" },
        };
        Tnodes.Add(diagramNode);
    }
    // used to create a Port.
    private PointPort CreatePort(double x, double y)
    {
        return new PointPort()
        {
            ID = string.Format("port{0}", ++portCount),
            Shape = PortShapes.Circle,
            Offset = new Point() { X = x, Y = y }
        };
    }
    // Method is used to create a Connector for the diagram.
    private void CreateConnector(string sourceId, string targetId, string label = default(string), DiagramObjectCollection<ConnectorSegment> segment = null, bool isDashLine = false)
    {
        Connector diagramConnector = new Connector()
        {
            ID = string.Format("connector{0}", ++connectorCount),
            SourceID = sourceId,
            TargetID = targetId,

        };
        if (isDashLine)
        {
            diagramConnector.Style = new ShapeStyle() { StrokeDashArray = "2,2" };
        }
        if (label != default(string))
        {
            var annotation = new PathAnnotation()
            {
                Content = label,
                Style = new TextShapeStyle() { Fill = "white" }
            };
            if ((sourceId == "node5" && targetId == "node6") || label == "Yes" || label == "No")
            {
                annotation.Height = 10;
                annotation.Width = 15;
            }
            diagramConnector.Annotations = new DiagramObjectCollection<PathAnnotation>() { annotation };
        }


        if (segment != null)
        {
            diagramConnector.Type = Segments.Orthogonal;
            diagramConnector.Segments = segment;
        }

        connectors.Add(diagramConnector);
    }
    // Method is used to create a node for the diagram.
    private void CreateNode(string id, double x, double y, FlowShapes shape, string label)
    {
        DiagramObjectCollection<PointPort> defaultsPorts = new DiagramObjectCollection<PointPort>();
        defaultsPorts.Add(CreatePort(0, 0.5));
        defaultsPorts.Add(CreatePort(0.5, 1));
        defaultsPorts.Add(CreatePort(1, 0.5));
        defaultsPorts.Add(CreatePort(0.5, 0));
        Node diagramNode = new Node()
        {
            ID = id,
            OffsetX = x,
            OffsetY = y,
            Width = 145,
            Ports = defaultsPorts,
            Height = 60,
            Style = new ShapeStyle { Fill = "#357BD2", StrokeColor = "White" },

            Shape = new FlowShape() { Type = Syncfusion.Blazor.Diagram.Shapes.Flow, Shape = shape },
            Annotations = new DiagramObjectCollection<ShapeAnnotation>
    {
                    new ShapeAnnotation
                    {
                        Content = label,
                        Style = new TextShapeStyle()
                        {
                          Color="White",

                           Fill = "transparent"
                        }
                    }
                }
        };

        nodes.Add(diagramNode);
    }
    // Method is used to create a Connector for the palette.
    private void CreatePaletteConnector(string id, Segments type, DecoratorShapes decoratorShape)
    {
        Connector diagramConnector = new Connector()
        {
            ID = id,
            Type = type,
            SourcePoint = new Point() { X = 0, Y = 0 },
            TargetPoint = new Point() { X = 60, Y = 60 },
            Style = new ShapeStyle() { StrokeWidth = 1, StrokeColor = "#757575" },
            TargetDecorator = new Decorator()
            {
                Shape = decoratorShape,
                Style = new ShapeStyle() { StrokeColor = "#757575", Fill = "#757575" }
            }
        };

        T2nodes.Add(diagramConnector);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
