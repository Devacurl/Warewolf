﻿using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warewolf.UITests.Tools.Data
{
    [CodedUITest]
    public class Assign
    {
        [TestMethod]
        [TestCategory("Tools")]
        public void Assign_Tool_Small_View_UITest()
        {
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.SmallView.DataGrid.Exists, "Assign tool DataGrid does not exist on large view after dragging tool in from the toolbox.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.SmallView.DataGrid.Row1.VariableCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 1 variable textbox does not exist on large view after dragging tool in from the toolbox.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.SmallView.DataGrid.Row1.ValueCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 1 value textbox does not exist on large view after dragging tool in from the toolbox.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.SmallView.DataGrid.Row2.VariableCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 2 variable textbox does not exist on large view after dragging tool in from the toolbox.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.SmallView.DataGrid.Row2.ValueCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 2 value textbox does not exist on large view after dragging tool in from the toolbox.");
        }

        [TestMethod]
        [TestCategory("Tools")]
        public void Assign_Tool_Open_Large_View_With_Double_Click_UITest()
        {
            UIMap.Open_Assign_Tool_Large_View();
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.LargeView.DataGrid.Exists, "Assign tool DataGrid does not exist on large view after openning it by double clicking the small view on the design surface.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.LargeView.DataGrid.Row1.VariableCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 1 variable textbox does not exist on large view after openning it by double clicking the small view on the design surface.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.LargeView.DataGrid.Row1.ValueCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 1 value textbox does not exist on large view after openning it by double clicking the small view on the design surface.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.LargeView.DataGrid.Row2.VariableCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 2 variable textbox does not exist on large view after openning it by double clicking the small view on the design surface.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.LargeView.DataGrid.Row2.ValueCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 2 value textbox does not exist on large view after openning it by double clicking the small view on the design surface.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.LargeView.OnErrorPane.Exists, "Assign tool OnError pane does not exist on large view after openning it by double clicking the small view on the design surface.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.DoneButton.Exists, "Assign tool done button does not exist on large view after openning it by double clicking the small view on the design surface.");
        }

        [TestMethod]
        [TestCategory("Tools")]
        public void Assign_Tool_Click_Done_Button_UITest()
        {
            UIMap.Open_Assign_Tool_Large_View();
            UIMap.Click_Assign_Tool_Large_View_Done_Button();
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.SmallView.DataGrid.Exists, "Assign tool DataGrid does not exist on small view after clicking done button.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.SmallView.DataGrid.Row1.VariableCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 1 variable textbox does not exist on small view after clicking done button.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.SmallView.DataGrid.Row1.ValueCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 1 value textbox does not exist on small view after clicking done button.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.SmallView.DataGrid.Row2.VariableCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 2 variable textbox does not exist on small view after clicking done button.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.SmallView.DataGrid.Row2.ValueCell.IntellisenseCombobox.Textbox.Exists, "Assign tool Row 2 value textbox does not exist on small view after clicking done button.");
        }

        [TestMethod]
        [TestCategory("Tools")]
        public void AssignToolOpenAndCloseLargeViewWithExpandAllToggleUITest()
        {
            UIMap.Click_Workflow_ExpandAll();
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.LargeView.Exists, "Assign tool large view does not exist after clicking expand all toggle button.");
            UIMap.Click_Workflow_CollapseAll();
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.SmallView.Exists, "Assign tool small view does not exist after clicking collapse all toggle button.");
        }

        [TestMethod]
        [TestCategory("Tools")]
        public void AssignDeleteToolUITest()
        {
            UIMap.Delete_Assign_With_Context_Menu();
        }

        [TestMethod]
        [TestCategory("Tools")]
        public void AssignToolUrlUITest()
        {
            UIMap.Click_Assign_Tool_url();
        }

        [TestMethod]
        [TestCategory("Tools")]
        public void ResizeAdornerMappings_Expected_AdornerMappingIsResized_UITest()
        {
            UIMap.Open_Assign_Tool_Large_View();
            var heightBefore = UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.Height;
            UIMap.Resize_Assign_LargeTool();
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.Height > heightBefore);            
        }

        [TestMethod]
        [TestCategory("Tools")]
        public void QuickVariableInputFromListTest()
        {
            UIMap.Open_Assign_Tool_Qvi_Large_View();
            UIMap.Enter_Text_Into_Assign_QviLarge_View();
            UIMap.Click_Assign_Tool_QviLarge_Preview();
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.PrefixcontainsinvaliText.Exists);
            UIMap.Click_PrefixContainsInvalidText_Hyperlink();
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.MultiAssign.QuickVariableInputContent.PrefixEdit.HasFocus);
        }

        [TestMethod]
        [TestCategory("Tools")]
        public void AssignTool_OpenQviUITest()
        {
            UIMap.Open_Assign_Tool_Qvi_Large_View();
        }

        [TestMethod]
        [TestCategory("Tools")]
        public void AssignToolDebugOutputUITest()
        {
            UIMap.Assign_Value_To_Variable_With_Assign_Tool_Small_View_Row_1();
            UIMap.Debug_Workflow_With_Ribbon_Button();
            UIMap.Click_Debug_Output_Assign_Cell();
        }

        [TestMethod]
        [TestCategory("Tools")]
        public void AssignToolAddRemoveVariablesUITest()
        {
            const string Variable1Name = "SomeVariable";
            const string Variable1Value = "50";
            UIMap.Enter_Variable_And_Value_Into_Assign("[[" + Variable1Name + "]]", Variable1Value, 1);
            Assert.AreEqual(Variable1Name, UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.ContentPane.ContentDockManager.SplitPaneRight.Variables.DatalistView.VariableTree.VariableTreeItem.TreeItem1.ScrollViewerPane.NameTextbox.Text, "Scalar variable not found in variable list after adding to assign tool row 1.");
            const string Variable2Name = "SomeOtherVariable";
            const string Variable2Value = "100";
            UIMap.Enter_Variable_And_Value_Into_Assign("[[" + Variable2Name + "]]", Variable2Value, 2);
            Assert.AreEqual(Variable2Name, UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.ContentPane.ContentDockManager.SplitPaneRight.Variables.DatalistView.VariableTree.VariableTreeItem.TreeItem2.ScrollViewerPane.NameTextbox.Text, "Scalar variable not found in variable list after adding to assign tool row 2.");
            UIMap.Remove_Assign_Row_1_With_Context_Menu();
        }

        #region Additional test attributes

        [TestInitialize]
        public void MyTestInitialize()
        {
            UIMap.SetPlaybackSettings();
#if !DEBUG
            UIMap.CloseHangingDialogs();
#endif
            UIMap.Click_New_Workflow_Ribbon_Button();
            UIMap.Drag_Toolbox_MultiAssign_Onto_DesignSurface();
        }

        UIMap UIMap
        {
            get
            {
                if (_UIMap == null)
                {
                    _UIMap = new UIMap();
                }

                return _UIMap;
            }
        }

        private UIMap _UIMap;

        #endregion
    }
}