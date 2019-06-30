using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebControlApp
{

    public partial class maketable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs args)
        {
            tbl.BorderStyle = BorderStyle.Inset;
            tbl.BorderWidth = Unit.Pixel(1);
        }

        protected void Make_Click(Object sender, EventArgs args)
        {
            //Remove all the current row and cell
            //This is not neccessary if the EnableViiewState is set to false.
            tbl.Controls.Clear();

            int rows = Int32.Parse(txtRows.Text);
            int cols = Int32.Parse(txtCols.Text);
            int rowCord, colCord;
            for (int row = 0; row < rows; row++)
            {
                if( row == 0)
                {
                    TableRow firstRow = new TableRow();
                    TableCell firstCell = new TableCell();
                    System.Web.UI.WebControls.Image emoji = new System.Web.UI.WebControls.Image();
                    emoji.ImageUrl = "images/cellpic.png";

                    firstCell.Controls.Add(emoji);
                    firstRow.Controls.Add(firstCell);
                    tbl.Controls.Add(firstRow);
                }

                TableRow rowNew = new TableRow();
                tbl.Controls.Add(rowNew);
                for (int col = 0; col < cols; col++)
                {
                    TableCell cellNew = new TableCell();
                    rowCord = row + 1;
                    colCord = col + 1;
                    cellNew.Text = $"cord: ({rowCord}, {colCord})";

                    if (chkBorder.Checked)
                    {
                        cellNew.BorderStyle = BorderStyle.Dashed;
                        cellNew.BorderColor = Color.BlueViolet;
                    }

                    rowNew.Controls.Add(cellNew);
                }
            }
        }
    }
}
