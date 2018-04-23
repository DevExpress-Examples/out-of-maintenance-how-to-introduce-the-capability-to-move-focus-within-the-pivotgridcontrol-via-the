using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid.ViewInfo;
using System.Drawing;

namespace DXSample {
    public class MyPivotGridControl : PivotGridControl {
        public MyPivotGridControl() : base() { }

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
            Point newFocusedCell = FocusedCell;
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
            FocusedCell = newFocusedCell;
        }

        public override void KeyDown(KeyEventArgs e) {
            base.KeyDown(e);
            if (e.KeyCode == Keys.Tab) ProcessTabKey(e.Shift);
        }
    }

    public class MyPivotGridViewInfoData : PivotGridViewInfoData {
        public MyPivotGridViewInfoData() : base() { }
        public MyPivotGridViewInfoData(IViewInfoControl control) : base(control) { }

        protected override PivotGridViewInfoBase CreateViewInfo() {
            return new MyPivotGridViewInfo(this);
        }
    }
}