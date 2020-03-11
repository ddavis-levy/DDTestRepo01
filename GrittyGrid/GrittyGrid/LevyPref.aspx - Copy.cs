using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace GrittyGrid
{
    public partial class LevyPref : System.Web.UI.Page
    {
        private void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Setting Selected index prior to binding RadGrid:
                //If the index is in detail table, parent items will be expanded
                //automatically 
                RadGrid1.SelectedIndexes.Add(1, 0, 1, 0, 0);
                //Index of 1, 0, 1, 0, 0 means:
                //1 - item with index 1 in the MasterTabelView
                //0 - detail table with index 0
                //1 - item with index 1 (the second item) in the first detail table
                //0 - 0 the third-level detail table
                //0 - the item with index 0 in the third-level table
            }
        }

        protected void RadGrid1_ItemUpdated(object source, Telerik.Web.UI.GridUpdatedEventArgs e)
        {
            string item = getItemName(e.Item.OwnerTableView.Name);
            string field = getFieldName(e.Item.OwnerTableView.Name);
            if (e.Exception != null)
            {
                e.KeepInEditMode = true;
                e.ExceptionHandled = true;
                DisplayMessage(item + " " + e.Item[field].Text + " cannot be updated. Reason: " + e.Exception.Message);
            }
            else
            {
                DisplayMessage(item + " " + e.Item[field].Text + " updated");
            }
        }

        protected void RadGrid1_ItemInserted(object source, GridInsertedEventArgs e)
        {
            string item = getItemName(e.Item.OwnerTableView.Name);
            if (e.Exception != null)
            {
                e.ExceptionHandled = true;
                DisplayMessage(item + " cannot be inserted. Reason: " + e.Exception.Message);
            }
            else
            {
                DisplayMessage(item + " inserted");
            }
        }

        protected void RadGrid1_ItemDeleted(object source, GridDeletedEventArgs e)
        {
            string item = getItemName(e.Item.OwnerTableView.Name);
            string field = getFieldName(e.Item.OwnerTableView.Name);
            if (e.Exception != null)
            {
                e.ExceptionHandled = true;
                DisplayMessage(item + " " + e.Item[field].Text + " cannot be deleted. Reason: " + e.Exception.Message);
            }
            else
            {
                DisplayMessage(item + " " + e.Item[field].Text + " deleted");
            }
        }

        protected void RadGrid1_InsertCommand(object source, GridCommandEventArgs e)
        {
            switch (e.Item.OwnerTableView.Name)
            {
                case "Orders":
                    {
                        GridDataItem parentItem = (GridDataItem)e.Item.OwnerTableView.ParentItem;
                        SqlDataSource2.InsertParameters["CustomerID"].DefaultValue = parentItem.OwnerTableView.DataKeyValues[parentItem.ItemIndex]["CustomerID"].ToString();
                    }
                    break;
                case "Details":
                    {
                        GridDataItem parentItem = (GridDataItem)e.Item.OwnerTableView.ParentItem;
                        SqlDataSource3.InsertParameters["OrderID"].DefaultValue = parentItem.OwnerTableView.DataKeyValues[parentItem.ItemIndex]["OrderID"].ToString();
                    }
                    break;
            }

        }

        protected void RadGrid1_ItemCreated(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridEditFormItem && !(e.Item is IGridInsertItem) && e.Item.IsInEditMode)
            {
                GridEditFormItem item = e.Item as GridEditFormItem;
                switch (item.OwnerTableView.Name)
                {
                    case "Customers":
                        TextBox customerIDBox = item["CustomerID"].Controls[0] as TextBox;
                        customerIDBox.Enabled = false;
                        break;
                    case "Details":
                        TextBox productIDBox = item["ProductID"].Controls[0] as TextBox;
                        productIDBox.Enabled = false;
                        break;
                }
            }
        }

        private String getItemName(string tableName)
        {
            switch (tableName)
            {
                case ("Customers"):
                    {
                        return "Customer";
                    }
                case ("Orders"):
                    {
                        return "Order";
                    }
                case ("Details"):
                    {
                        return "Details for order";
                    }
                default: return "";
            }
        }

        private String getFieldName(string tableName)
        {
            switch (tableName)
            {
                case ("Customers"):
                    {
                        return "CustomerID";
                    }
                case ("Orders"):
                    {
                        return "OrderID";
                    }
                case ("Details"):
                    {
                        return "OrderID";
                    }
                default: return "";
            }
        }

        private void DisplayMessage(string text)
        {
            RadGrid1.Controls.Add(new LiteralControl(string.Format("<span style='color:red'>{0}</span>", text)));
        }

    }
}
