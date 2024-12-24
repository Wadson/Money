using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace EDebugViewer.Forms
{
	/// <summary>
	/// Summary description for AutoResizeDataGridTableStyle.
	/// </summary>
	public class AutoResizeDataGridTableStyle: DataGridTableStyle
	{
		private int OFFSET_GRID = 39;

		public AutoResizeDataGridTableStyle(): base()
		{
			BackColor = Color.WhiteSmoke;
			AlternatingBackColor = Color.Lavender;
			ForeColor = Color.MidnightBlue;
			GridLineColor = Color.Gainsboro;
			HeaderBackColor = Color.MidnightBlue;
			HeaderForeColor = Color.WhiteSmoke;
			LinkColor = Color.Teal;
			SelectionBackColor = Color.CadetBlue;
			SelectionForeColor = Color.WhiteSmoke;
			ColumnHeadersVisible = true;
			RowHeadersVisible = true;
			HeaderFont = new Font("Microsoft Sans Serif", 8);
		}

		/// <summary>
		/// Called when the DataSource property of the parent DataGrid 
		/// changes. When the new source is a DataTable, rebuild the 
		/// DataGridColumnStyles and resize.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void OnDataSourceChanged(object sender, EventArgs e)
		{
			GridColumnStyles.Clear();
			if(DataGrid != null && DataGrid.DataSource != null && DataGrid.DataSource is DataTable)
			{
				DataTable currentTable = (DataTable)DataGrid.DataSource;
				foreach(DataColumn column in currentTable.Columns)
				{
					DataGridColumnStyle style = new DataGridTextBoxColumn();
					style.HeaderText = column.ColumnName;
					style.MappingName = column.ColumnName;
					GridColumnStyles.Add(style);
				}
			}
			// Call the eventhandler for resize events
			OnDataGridResize(this,new EventArgs());
		}

		public void OnDataGridResize(object sender, EventArgs e)
		{
			// Parent?
			if(DataGrid != null)
			{
				// Get column width
				int columnWidth;
				if( (columnWidth = GetGridColumnWidth()) != -1)
				{
					// Get the client width
					int clientWidth = DataGrid.ClientSize.Width;
					// Are there columns? redundant check
					if(GridColumnStyles.Count > 0)
					{
						// whats the newWidth
						int newWidth = GridColumnStyles[GridColumnStyles.Count - 1].Width + clientWidth - columnWidth;
						// is the new width valid?
						if(newWidth > PreferredColumnWidth)
							GridColumnStyles[GridColumnStyles.Count - 1].Width = newWidth;
						else
							GridColumnStyles[GridColumnStyles.Count - 1].Width = PreferredColumnWidth;
					}
				}
				// Redraw
				DataGrid.Invalidate(true);
			}
		}

		private int GetGridColumnWidth()
		{
			// No columns, return error
			if(GridColumnStyles.Count == 0)
				return -1;
			// Easy 1
			int width = 0;
			foreach(DataGridColumnStyle columnStyle in GridColumnStyles)
			{
				width += columnStyle.Width;
			}
		
			return width + OFFSET_GRID;
		}
	}
}
