// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Radzen.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "E:\Dev\radzen-blazor\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenGrid.razor"
using System.Linq.Expressions;

#line default
#line hidden
#line 2 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenGrid.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenGrid.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 4 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenGrid.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenGrid.razor"
using Radzen;

#line default
#line hidden
#line 6 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenGrid.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenGrid<TItem> : PagedDataBoundComponent<TItem>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 490 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenGrid.razor"
       
    Dictionary<int, int> rowSpans = new Dictionary<int, int>();

    ElementReference scrollableHeader;
    ElementReference scrollableBody;

    string getFilterDateFormat(RadzenGridColumn<TItem> column)
    {
        if (column != null && !string.IsNullOrEmpty(column.FormatString))
        {
            var formats = column.FormatString.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            if (formats.Length > 0)
            {
                var format = formats[0].Trim().Split(':');
                if (format.Length > 1)
                {
                    return format[1].Trim();
                }
            }
        }

        return FilterDateFormat;
    }

    [Parameter]
    public LogicalFilterOperator LogicalFilterOperator { get; set; } = LogicalFilterOperator.And;

    [Parameter]
    public FilterMode FilterMode { get; set; } = FilterMode.Simple;

    [Parameter]
    public DataGridExpandMode ExpandMode { get; set; } = DataGridExpandMode.Multiple;

    [Parameter]
    public DataGridEditMode EditMode { get; set; } = DataGridEditMode.Multiple;

    [Parameter]
    public string FilterText { get; set; } = "Filter";

    [Parameter]
    public string AndOperatorText { get; set; } = "And";

    [Parameter]
    public string OrOperatorText { get; set; } = "Or";

    [Parameter]
    public string ApplyFilterText { get; set; } = "Apply";

    [Parameter]
    public string ClearFilterText { get; set; } = "Clear";

    [Parameter]
    public string EqualsText { get; set; } = "Equals";

    [Parameter]
    public string NotEqualsText { get; set; } = "Not equals";

    [Parameter]
    public string LessThanText { get; set; } = "Less than";

    [Parameter]
    public string LessThanOrEqualsText { get; set; } = "Less than or equals";

    [Parameter]
    public string GreaterThanText { get; set; } = "Greater than";

    [Parameter]
    public string GreaterThanOrEqualsText { get; set; } = "Greater than or equals";

    [Parameter]
    public string EndsWithText { get; set; } = "Ends with";

    [Parameter]
    public string ContainsText { get; set; } = "Contains";

    [Parameter]
    public string StartsWithText { get; set; } = "Starts with";

    class NumericFilterEventCallback
    {
        public static EventCallback<T> Create<T>(object receiver, Action<T> action)
        {
            return EventCallback.Factory.Create<T>(receiver, action);
        }

        public static Action<T> Action<T>(Action<object> action)
        {
            return args => action(args);
        }
    }

    RenderFragment DrawNumericFilter(RadzenGridColumn<TItem> column, bool force = true, bool isFirst = true)
    {
        return new RenderFragment(builder =>
        {
            var type = Nullable.GetUnderlyingType(column.FilterPropertyType) != null ?
                column.FilterPropertyType : typeof(Nullable<>).MakeGenericType(column.FilterPropertyType);

            var numericType = typeof(RadzenNumeric<>).MakeGenericType(type);

            builder.OpenComponent(0, numericType);

            builder.AddAttribute(1, "Value", isFirst ? column.FilterValue : column.SecondFilterValue);
            builder.AddAttribute(2, "Style", "width:100%");

            Action<object> action;
            if (force)
            {
                action = args => OnFilter(new ChangeEventArgs() { Value = args }, column, isFirst);
            }
            else
            {
                action = args => column.SetFilterValue(args, isFirst);
            }

            var eventCallbackGenericCreate = typeof(NumericFilterEventCallback).GetMethod("Create").MakeGenericMethod(type);
            var eventCallbackGenericAction = typeof(NumericFilterEventCallback).GetMethod("Action").MakeGenericMethod(type);

            builder.AddAttribute(3, "Change", eventCallbackGenericCreate.Invoke(this,
                new object[] { this, eventCallbackGenericAction.Invoke(this, new object[] { action }) }));

            builder.CloseComponent();
        });
    }

    string getFilterInputId(RadzenGridColumn<TItem> column)
    {
        return string.Join("", $"{UniqueID}".Split('.')) + column.GetFilterProperty();
    }

    [Parameter]
    public FilterCaseSensitivity FilterCaseSensitivity { get; set; } = FilterCaseSensitivity.Default;

    [Parameter]
    public int FilterDelay { get; set; } = 500;

    [Parameter]
    public string FilterDateFormat { get; set; }

    [Parameter]
    public string ColumnWidth { get; set; }

    private string _emptyText = "No records to display.";
    [Parameter]
    public string EmptyText
    {
        get { return _emptyText; }
        set
        {
            if (value != _emptyText)
            {
                _emptyText = value;
            }
        }
    }

    [Parameter]
    public RenderFragment EmptyTemplate { get; set; }

    [Parameter]
    public bool AllowSorting { get; set; }

    [Parameter]
    public bool AllowFiltering { get; set; }

    [Parameter]
    public bool AllowColumnResize { get; set; }

    string getColumnResizerId(int columnIndex)
    {
        return string.Join("", $"{UniqueID}".Split('.')) + columnIndex;
    }

    async Task StartColumnResize(MouseEventArgs args, int columnIndex)
    {
        await JSRuntime.InvokeVoidAsync("Radzen.startColumnResize", getColumnResizerId(columnIndex), Reference, columnIndex, args.ClientX);
    }

    [JSInvokable("RadzenGrid.OnColumnResized")]
    public async Task OnColumnResized(int columnIndex, double value)
    {
        var column = this.ColumnsCollection.Where(c => c.Visible).ToList()[columnIndex];
        column.SetWidth($"{value}px");
        await ColumnResized.InvokeAsync(new ColumnResizedEventArgs<TItem>
        {
            Column = column,
            Width = value,
        });
    }

    [Parameter]
    public EventCallback<ColumnResizedEventArgs<TItem>> ColumnResized { get; set; }

    public override IQueryable<TItem> View
    {
        get
        {
            var view = base.View.Where<TItem>(columns);

            if (!string.IsNullOrEmpty(orderBy))
            {
                if (typeof(TItem) == typeof(object))
                {
                    var firstItem = view.FirstOrDefault();
                    if (firstItem != null)
                    {
                        view = view.Cast(firstItem.GetType()).AsQueryable().OrderBy(orderBy).Cast<TItem>();
                    }
                }
                else
                {
                    view = view.OrderBy(orderBy);
                }
            }

            return view;
        }
    }


    object _value;

    [Parameter]
    public object Value
    {
        get
        {
            return _value;
        }
        set
        {
            if (!object.Equals(_value, value))
            {
                _value = value;

                selectedItems.Clear();

                if (_value != null)
                {
                    var values = _value as IEnumerable<TItem>;
                    if (values != null && SelectionMode == DataGridSelectionMode.Multiple)
                    {
                        values.ToList().ForEach(i => selectedItems.Add(i, true));
                    }
                    else
                    {
                        selectedItems.Add((TItem)_value, true);
                    }
                }

                ValueChanged?.Invoke(_value);
            }
        }
    }

    [Parameter]
    public Action<object> ValueChanged { get; set; }

    [Parameter]
    public EventCallback<TItem> RowSelect { get; set; }

    [Parameter]
    public EventCallback<TItem> RowDeselect { get; set; }

    [Parameter]
    public EventCallback<TItem> RowClick { get; set; }

    [Parameter]
    public EventCallback<TItem> RowDoubleClick { get; set; }

    [Parameter]
    public EventCallback<TItem> RowExpand { get; set; }

    [Parameter]
    public EventCallback<TItem> RowCollapse { get; set; }

    [Parameter]
    public Action<RowRenderEventArgs<TItem>> RowRender { get; set; }

    [Parameter]
    public Action<CellRenderEventArgs<TItem>> CellRender { get; set; }

    [Parameter]
    public Action<GridRenderEventArgs<TItem>> Render { get; set; }

    [Parameter]
    public RenderFragment Columns { get; set; }

    public IList<RadzenGridColumn<TItem>> ColumnsCollection
    {
        get
        {
            return columns;
        }
    }

    [Parameter]
    public bool Responsive { get; set; } = true;

    protected override void OnDataChanged()
    {
        Reset(!IsOData() && !LoadData.HasDelegate);
    }

    public void Reset(bool resetColumnFilters = true, bool resetRowState = false)
    {
        _view = null;
        _value = default(TItem);

        if (resetRowState)
        {
            selectedItems.Clear();
            expandedItems.Clear();
        }

        if (resetColumnFilters)
        {
            columns.ForEach(c => { c.SetFilterValue(null); c.SetSecondFilterOperator(null); });
        }
    }

    public async override Task Reload()
    {
        _view = null;

        if (Data != null && !LoadData.HasDelegate)
        {
            Count = View.Count();
        }

        Query.Skip = skip;
        Query.Top = PageSize;
        Query.OrderBy = orderBy;

        var filterString = columns.ToFilterString<TItem>();
        Query.Filter = filterString;

        if (LoadData.HasDelegate)
        {
            await LoadData.InvokeAsync(new Radzen.LoadDataArgs()
            {
                Skip = skip,
                Top = PageSize,
                OrderBy = orderBy,
                Filter = IsOData() ? columns.ToODataFilterString<TItem>() : filterString,
                Filters = columns.Where(c => c.Filterable && c.Visible && c.FilterValue != null).Select(c => new FilterDescriptor()
                {
                    Property = c.GetFilterProperty(),
                    FilterValue = c.FilterValue,
                    FilterOperator = (FilterOperator)Enum.Parse(typeof(FilterOperator), QueryableExtension.FilterOperators[c.FilterOperator]),
                    SecondFilterValue = c.SecondFilterValue,
                    SecondFilterOperator = (FilterOperator)Enum.Parse(typeof(FilterOperator), QueryableExtension.FilterOperators[c.SecondFilterOperator]),
                    LogicalFilterOperator = c.LogicalFilterOperator
                }),
                Sorts = columns.Where(c => c.Sortable && c.Visible && (orderBy.Contains($"{c.GetSortProperty()} asc") || orderBy.Contains($"{c.GetSortProperty()} desc"))).Select(c => new SortDescriptor()
                {
                    Property = c.GetSortProperty(),
                    SortOrder = orderBy.Contains($"{c.GetSortProperty()} asc") ? SortOrder.Ascending : SortOrder.Descending,
                })
            });
        }

        CalculatePager();

        if (!LoadData.HasDelegate)
        {
            StateHasChanged();
        }
    }

    internal async Task ChangeState()
    {
        await InvokeAsync(StateHasChanged);
    }

    protected override Task OnParametersSetAsync()
    {
        if (Visible && !LoadData.HasDelegate && _view == null)
        {
            InvokeAsync(Reload);
        }
        else
        {
            CalculatePager();
        }

        return Task.CompletedTask;
    }

    Dictionary<TItem, bool> expandedItems = new Dictionary<TItem, bool>();
    protected string ExpandedItemStyle(TItem item)
    {
        return expandedItems.Keys.Contains(item) ? "rz-row-toggler rzi-grid-sort  rzi-chevron-circle-down" : "rz-row-toggler rzi-grid-sort  rzi-chevron-circle-right";
    }

    Dictionary<TItem, bool> selectedItems = new Dictionary<TItem, bool>();
    protected string RowStyle(TItem item, int index)
    {
        var evenOrOdd = index % 2 == 0 ? "rz-datatable-even" : "rz-datatable-odd";

        return (RowSelect.HasDelegate || ValueChanged != null || SelectionMode == DataGridSelectionMode.Multiple) && selectedItems.Keys.Contains(item) ? $"rz-state-highlight {evenOrOdd} " : $"{evenOrOdd} ";
    }

    protected Tuple<Radzen.RowRenderEventArgs<TItem>, IReadOnlyDictionary<string, object>> RowAttributes(TItem item, int index)
    {
        var args = new Radzen.RowRenderEventArgs<TItem>() { Data = item, Expandable = Template != null };

        if (RowRender != null)
        {
            RowRender(args);
        }

        return new Tuple<Radzen.RowRenderEventArgs<TItem>, IReadOnlyDictionary<string, object>>(args, new System.Collections.ObjectModel.ReadOnlyDictionary<string, object>(args.Attributes));
    }

    protected IReadOnlyDictionary<string, object> CellAttributes(TItem item, RadzenGridColumn<TItem> column)
    {
        var args = new Radzen.CellRenderEventArgs<TItem>() { Data = item, Column = column };

        if (CellRender != null)
        {
            CellRender(args);
        }

        return new System.Collections.ObjectModel.ReadOnlyDictionary<string, object>(args.Attributes);
    }

    private bool visibleChanged = false;
    private bool firstRender = true;

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        var emptyTextChanged = parameters.DidParameterChange(nameof(EmptyText), EmptyText);
        if (emptyTextChanged)
        {
            await ChangeState();
        }

        visibleChanged = parameters.DidParameterChange(nameof(Visible), Visible);

        await base.SetParametersAsync(parameters);

        if (visibleChanged && !firstRender)
        {
            if (Visible == false)
            {
                Dispose();
            }
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);

        if (Visible)
        {
            var args = new Radzen.GridRenderEventArgs<TItem>() { Grid = this, FirstRender = firstRender };

            if (Render != null)
            {
                Render(args);
            }
        }

        this.firstRender = firstRender;

        if (firstRender || visibleChanged)
        {
            visibleChanged = false;

            if (Visible)
            {
                await JSRuntime.InvokeVoidAsync("Radzen.adjustDataGridHeader", scrollableHeader, scrollableBody);
            }
        }
    }

    public async System.Threading.Tasks.Task ExpandRow(TItem item)
    {
        await ExpandItem(item);
    }

    protected async System.Threading.Tasks.Task ExpandItem(TItem item)
    {
        if (ExpandMode == DataGridExpandMode.Single && expandedItems.Keys.Any())
        {
            var itemToCollapse = expandedItems.Keys.FirstOrDefault();
            if (itemToCollapse != null)
            {
                expandedItems.Remove(itemToCollapse);
                await RowCollapse.InvokeAsync(itemToCollapse);

                if(object.Equals(item,itemToCollapse))
                {
                    return;
                }

            }
        }

        if (!expandedItems.Keys.Contains(item))
        {
            expandedItems.Add(item, true);
            await RowExpand.InvokeAsync(item);
        }
        else
        {
            expandedItems.Remove(item);
            await RowCollapse.InvokeAsync(item);
        }
    }

    protected string DateFilterOperatorStyle(RadzenGridColumn<TItem> column, string value)
    {
        return column.FilterOperator == value ?
            "rz-listbox-item  rz-state-highlight" :
            "rz-listbox-item ";
    }

    protected async Task ClearFilter(RadzenGridColumn<TItem> column, bool closePopup = false)
    {
        if (closePopup)
        {
            await JSRuntime.InvokeVoidAsync("Radzen.closePopup", $"{PopupID}{column.GetFilterProperty()}");
        }
        column.SetFilterValue(null);
        column.SetFilterValue(null, false);
        skip = 0;
        CurrentPage = 0;
        await InvokeAsync(Reload);
    }

    protected async Task ApplyFilter(RadzenGridColumn<TItem> column, bool closePopup = false)
    {
        if (closePopup)
        {
            await JSRuntime.InvokeVoidAsync("Radzen.closePopup", $"{PopupID}{column.GetFilterProperty()}");
        }
        OnFilter(new ChangeEventArgs() { Value = column.FilterValue }, column, true);
    }

    protected void ApplyDateFilterByFilterOperator(RadzenGridColumn<TItem> column, string filterOperator)
    {
        column.SetFilterOperator(filterOperator);
    }

    [Parameter]
    public DataGridSelectionMode SelectionMode { get; set; } = DataGridSelectionMode.Single;

    internal async Task OnRowClick(object item)
    {
        await RowClick.InvokeAsync((TItem)item);
        await OnRowSelect(item);
    }

    internal async System.Threading.Tasks.Task OnRowSelect(object item, bool raiseChange = true)
    {
        if (SelectionMode == DataGridSelectionMode.Single && item != null && selectedItems.Keys.Contains((TItem)item))
        {
            // Legacy RowSelect raise
            if (raiseChange)
            {
                await RowSelect.InvokeAsync((TItem)item);
            }
            return;
        }

        if (SelectionMode == DataGridSelectionMode.Single && selectedItems.Keys.Any())
        {
            var itemToDeselect = selectedItems.Keys.FirstOrDefault();
            if (itemToDeselect != null)
            {
                selectedItems.Remove(itemToDeselect);
                await RowDeselect.InvokeAsync(itemToDeselect);
            }
        }

        if (item != null)
        {
            if (!selectedItems.Keys.Contains((TItem)item))
            {
                selectedItems.Add((TItem)item, true);
                if (raiseChange)
                {
                    await RowSelect.InvokeAsync((TItem)item);
                }
            }
            else
            {
                selectedItems.Remove((TItem)item);
                await RowDeselect.InvokeAsync((TItem)item);
            }
        }
        else
        {
            if (raiseChange)
            {
                await RowSelect.InvokeAsync((TItem)item);
            }
        }

        var value = selectedItems.Keys;

        _value = SelectionMode == DataGridSelectionMode.Multiple ? (object)value : value.FirstOrDefault();
        ValueChanged?.Invoke(_value);
        StateHasChanged();
    }

    public async System.Threading.Tasks.Task SelectRow(TItem item)
    {
        await OnRowSelect(item, true);
    }

    internal async System.Threading.Tasks.Task OnRowDblClick(TItem item)
    {
        await RowDoubleClick.InvokeAsync(item);
    }

    [Parameter]
    public EventCallback<TItem> RowEdit { get; set; }

    [Parameter]
    public EventCallback<TItem> RowUpdate { get; set; }

    [Parameter]
    public EventCallback<TItem> RowCreate { get; set; }

    Dictionary<TItem, bool> editedItems = new Dictionary<TItem, bool>();
    Dictionary<TItem, EditContext> editContexts = new Dictionary<TItem, EditContext>();

    public async System.Threading.Tasks.Task EditRow(TItem item)
    {
        if(itemToInsert != null)
        {
            CancelEditRow(itemToInsert);
        }

        await EditRowInternal(item);
    }

    async System.Threading.Tasks.Task EditRowInternal(TItem item)
    {
        if (EditMode == DataGridEditMode.Single && editedItems.Keys.Any())
        {
            var itemToCancel = editedItems.Keys.FirstOrDefault();
            if (itemToCancel != null)
            {
                editedItems.Remove(itemToCancel);
                editContexts.Remove(itemToCancel);
            }
        }

        if (!editedItems.Keys.Contains(item))
        {
            editedItems.Add(item, true);

            var editContext = new EditContext(item);
            editContexts.Add(item, editContext);

            await RowEdit.InvokeAsync(item);

            StateHasChanged();
        }
    }

    public async System.Threading.Tasks.Task UpdateRow(TItem item)
    {
        if (editedItems.Keys.Contains(item))
        {
            var editContext = editContexts[item];

            if (editContext.Validate())
            {
                editedItems.Remove(item);
                editContexts.Remove(item);

                if (object.Equals(itemToInsert, item))
                {
                    await RowCreate.InvokeAsync(item);
                    itemToInsert = default(TItem);
                }
                else
                {
                    await RowUpdate.InvokeAsync(item);
                }
            }

            StateHasChanged();
        }
    }

    public void CancelEditRow(TItem item)
    {
        if (object.Equals(itemToInsert, item))
        {
            var list = this.PagedView.ToList();
            list.Remove(item);
            this._view = list.AsQueryable();
            this.Count = this.View.Count();
            itemToInsert = default(TItem);
            StateHasChanged();
        }
        else
        {
            int hash = item.GetHashCode();

            if (editedItems.Keys.Contains(item))
            {
                editedItems.Remove(item);
                editContexts.Remove(item);

                StateHasChanged();
            }
        }
    }

    public bool IsRowInEditMode(TItem item)
    {
        return editedItems.Keys.Contains(item);
    }

    TItem itemToInsert;
    public async System.Threading.Tasks.Task InsertRow(TItem item)
    {
        itemToInsert = item;
        var list = this.PagedView.ToList();
        list.Insert(0, item);
        this._view = list.AsQueryable();
        this.Count = this._view.Count();
        await EditRowInternal(item);
    }

    protected void OnSort(EventArgs args, RadzenGridColumn<TItem> column)
    {
        string property = column.GetSortProperty();
        if (AllowSorting && column.Sortable && !string.IsNullOrEmpty(property))
        {
            OrderBy(property);
        }
    }

    protected void OnFilterKeyPress(EventArgs args, RadzenGridColumn<TItem> column)
    {
        Debounce(() => DebounceFilter(column), FilterDelay);
    }

    async Task DebounceFilter(RadzenGridColumn<TItem> column)
    {
        var inputValue = await JSRuntime.InvokeAsync<string>("Radzen.getInputValue", getFilterInputId(column));
        if (!object.Equals(column.FilterValue, inputValue))
        {
            await InvokeAsync(() => { OnFilter(new ChangeEventArgs() { Value = inputValue }, column); });
        }
    }

    protected void OnFilter(ChangeEventArgs args, RadzenGridColumn<TItem> column, bool force = false, bool isFirst = true)
    {
        string property = column.GetFilterProperty();
        if (AllowFiltering && column.Filterable && !string.IsNullOrEmpty(property))
        {
            if (!object.Equals(isFirst ? column.FilterValue : column.SecondFilterValue, args.Value) || force)
            {
                column.SetFilterValue(args.Value, isFirst);
                skip = 0;
                CurrentPage = 0;
                InvokeAsync(Reload);
            }
        }
    }

    string orderBy;

    List<RadzenGridColumn<TItem>> columns = new List<RadzenGridColumn<TItem>>();

    public void AddColumn(RadzenGridColumn<TItem> column)
    {
        if (columns.IndexOf(column) == -1)
        {
            columns.Add(column);
            StateHasChanged();
        }
    }

    public void RemoveColumn(RadzenGridColumn<TItem> column)
    {
        if (columns.Contains(column))
        {
            columns.Remove(column);
            if (!disposed)
            {
                try { InvokeAsync(StateHasChanged); } catch { }
            }
        }
    }

    private bool IsOData()
    {
        return Data != null && typeof(ODataEnumerable<TItem>).IsAssignableFrom(Data.GetType());
    }

    public void OrderBy(string property)
    {
        SetColumnSortOrder(property);
        var p = IsOData() ? property.Replace('.', '/') : PropertyAccess.GetProperty(property);
        orderBy = orderBy == $"{p} desc" || orderBy == null || orderBy.IndexOf(p) == -1 ? $"{p} asc" : $"{p} desc";
        InvokeAsync(Reload);
    }

    public void OrderByDescending(string property)
    {
        SetColumnSortOrder(property);
        var p = IsOData() ? property.Replace('.', '/') : PropertyAccess.GetProperty(property);
        orderBy = $"{p} desc";
        InvokeAsync(Reload);
    }

    internal void SetColumnSortOrder(string property)
    {
        var column = columns.Where(c => c.GetSortProperty() == property).FirstOrDefault();
        if(column != null)
        {
            if (column.SortOrder == null)
            {
                column.SortOrder = SortOrder.Ascending;
            }
            else if (column.SortOrder == SortOrder.Ascending)
            {
                column.SortOrder = SortOrder.Descending;
            }
            else if (column.SortOrder == SortOrder.Descending)
            {
                column.SortOrder = null;
            }
        }
    }

    protected override string GetComponentCssClass()
    {
        var additionalClasses = new List<string>();

        if (CurrentStyle.ContainsKey("height"))
        {
            additionalClasses.Add("rz-has-height");
        }

        if (RowSelect.HasDelegate || ValueChanged != null || SelectionMode == DataGridSelectionMode.Multiple)
        {
            additionalClasses.Add("rz-selectable");
        }

        if (Responsive)
        {
            additionalClasses.Add("rz-datatable-reflow");
        }

        return $"rz-has-paginator rz-datatable  rz-datatable-scrollable {String.Join(" ", additionalClasses)}";
    }

    private string getHeaderStyle()
    {
        var additionalStyle = Style != null && Style.IndexOf("height:") != -1 ? "padding-right: 17px;" : "";
        return $"margin-left:0px;{additionalStyle}";
    }

    private string getFilterIconCss(RadzenGridColumn<TItem> column)
    {
        var additionalStyle = column.FilterValue != null || column.SecondFilterValue != null ? "rz-grid-filter-active" : "";
        return $"rzi rz-grid-filter-icon {additionalStyle}";
    }

    public Query Query { get; private set; } = new Query();

    private string PopupID
    {
        get
        {
            return $"popup{UniqueID}";
        }
    }

    public override void Dispose()
    {
        base.Dispose();

        foreach (var column in columns.Where(c => c.Visible))
        {
            JSRuntime.InvokeVoidAsync("Radzen.destroyPopup", $"{PopupID}{column.GetFilterProperty()}");
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
