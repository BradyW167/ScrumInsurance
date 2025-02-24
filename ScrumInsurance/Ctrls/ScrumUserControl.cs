using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance
{
    public class ScrumUserControl : UserControl
    {
        private TableLayoutPanel parentPanel_;

        protected Session session_;



        public ScrumUserControl() {}

        public void setParentPanel(TableLayoutPanel parentPanel) { parentPanel_ = parentPanel; }

        public void setSession(Session session) { session_ = session; }

        public TableLayoutPanel getParentPanel() { return parentPanel_; }

        public Session getSession() { return session_; }

        // When called without an input control to load
        // Load this control into the parent panel
        public void loadControl() { loadControl(this); }

        // Load input control into parent panel
        public void loadControl(ScrumUserControl control)
        {
            if (parentPanel_ != null)
            {
                int columnIndex = 0;
                int rowIndex = 0;

                // Load the new UserControl
                control.Dock = DockStyle.Fill;

                control.AutoSize = false;

                control.Anchor = AnchorStyles.None; // Prevent stretching

                // Add new UserControl to the same cell in the parent panel
                parentPanel_.Controls.Add(control, columnIndex, rowIndex);

                CenterUserControl(control);
            }
        }

        // Deletes the current user control in parent panel and load a new input control
        public void swapControl(ScrumUserControl newControl)
        {
            // Remove this current UserControl
            parentPanel_.Controls.Remove(this);
            this.Dispose();

            newControl.setParentPanel(parentPanel_);
            newControl.setSession(session_);

            loadControl(newControl);
        }

        // Function to center the UserControl inside the column
        public void CenterUserControl(ScrumUserControl control)
        {
            int columnIndex = 0; // Assuming it's in column 0
            int rowIndex = 0;     // Assuming it's in row 0

            // Get the column width
            int columnWidth = parentPanel_.GetColumnWidths()[columnIndex];
            int rowHeight = parentPanel_.GetRowHeights()[rowIndex];

            // Set the position dynamically
            control.Left = (columnWidth - control.Width) / 2;
            control.Top = (rowHeight - control.Height) / 2;
        }
    }
}
