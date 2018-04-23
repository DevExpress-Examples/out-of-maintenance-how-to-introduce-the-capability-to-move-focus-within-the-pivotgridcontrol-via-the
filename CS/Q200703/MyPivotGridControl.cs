using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid.ViewInfo;
using System.Drawing;

namespace DXSample {
    public class MyPivotGridControl : PivotGridControl {
        public MyPivotGridControl() : base() { }
        public MyPivotGridControl(PivotGridViewInfoData viewInfoData) : base(viewInfoData) { }

        protected override bool ProcessDialogKey(Keys keyData) {
            Keys key = keyData & (~Keys.Modifiers);
            if (key == Keys.Tab) return false;
            return base.ProcessDialogKey(keyData);
        }

        protected override PivotGridViewInfoData CreateData() {
            return new MyPivotGridViewInfoData(this);
        }
    }

    public class MyPivotGridViewInfo : PivotGridViewInfo {
        public MyPivotGridViewInfo(PivotGridViewInfoData data) : base(data) { }

        private void ProcessTabKey(bool shift) {
            Point newFocusedCell = VisualItems.FocusedCell;
            if (shift) {
                if (newFocusedCell.X == 0 && newFocusedCell.Y > 0) {
                    newFocusedCell.X = CellsArea.ColumnCount - 1;
                    newFocusedCell.Y -= 1;
                } else if (newFocusedCell.X > 0) newFocusedCell.X -= 1;
            } else
                if (newFocusedCell.X == CellsArea.ColumnCount - 1 &&
                    newFocusedCell.Y < CellsArea.RowCount - 1) {
                    newFocusedCell.X = 0;
                    newFocusedCell.Y += 1;
                } else if (newFocusedCell.X < CellsArea.ColumnCount - 1) newFocusedCell.X += 1;
            VisualItems.StartSelection(true);
            VisualItems.FocusedCell = newFocusedCell;
        }

        public override void KeyDown(KeyEventArgs e) {
            if (e.KeyCode == Keys.Tab)
                ProcessTabKey(e.Shift);
            else base.KeyDown(e);
        }
    }

    public class MyPivotGridViewInfoData : PivotGridViewInfoData {
        public MyPivotGridViewInfoData() : base() { }
        public MyPivotGridViewInfoData(IViewInfoControl control) : base(control) { }

        protected override PivotGridViewInfo CreateViewInfo() {
            return new MyPivotGridViewInfo(this);
        }
    }
}