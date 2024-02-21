using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageExample
{
    public partial class PanelExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label theLabel;
            Table theTable = new Table();
            TableRow tr;
            TableCell td;
           
            for (int i = 0; i < 5; i++)
            {
                tr = new TableRow();
                for (int j = 0; j < 5; j++)
                {
                    theLabel = new Label();
                    theLabel.Text = i.ToString() + j.ToString();
                    td = new TableCell();
                    td.Controls.Add(theLabel);
                    tr.Cells.Add(td);
                }
                theTable.Rows.Add(tr);
            }
            

            
           

            pnlOut.Controls.Add(theTable);
        }
    }
}