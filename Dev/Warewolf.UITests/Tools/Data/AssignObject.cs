﻿using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warewolf.UITests.Tools.Data
{
    /// <summary>
    /// Summary description for WorkflowDesignSurface
    /// </summary>
    [CodedUITest]
    public class AssignObject
    {
        [TestMethod]
        [TestCategory("Tools")]
        public void AssignObject_SmallViewUITest()
        {
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.AssignObject.SmallView.DataGrid.Row1.VariableCell.VariableTextbox.Exists, "Row 1 variable textbox does not exist on assign object tool small view after dragging tool in from the toolbox.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.AssignObject.SmallView.DataGrid.Row1.ValueCell.ValueTextbox.Exists, "Row 1 value textbox does not exist on assign object tool small view after dragging tool in from the toolbox.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.AssignObject.SmallView.DataGrid.Row2.VariableCell.VariableTextbox.Exists, "Row 2 does not exist on assign object tool small view after dragging tool in from the toolbox.");
            Assert.IsTrue(UIMap.MainStudioWindow.DockManager.SplitPaneMiddle.TabManSplitPane.TabMan.WorkflowTab.WorkSurfaceContext.WorkflowDesignerView.DesignerView.ScrollViewerPane.ActivityTypeDesigner.WorkflowItemPresenter.Flowchart.AssignObject.SmallView.DataGrid.Row2.ValueCell.ValueTextbox.Exists, "Row 2 value textbox does not exist on assign object tool small view after dragging tool in from the toolbox.");
        }

        [TestMethod]
		[TestCategory("Tools")]
        public void AssignObject_OpenLargeViewUITest()
        {            
            UIMap.Open_AssignObject_Large_Tool();
        }

        [TestMethod]
		[TestCategory("Tools")]
        public void AssignObject_OpenQIVLargeViewUITest()
        {
            UIMap.Open_AssignObject_QVI_LargeView();
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
            UIMap.Drag_Toolbox_AssignObject_Onto_DesignSurface();
        }

        UIMap UIMap
        {
            get
            {
                if (_uiMap == null)
                {
                    _uiMap = new UIMap();
                }

                return _uiMap;
            }
        }

        private UIMap _uiMap;

        #endregion
    }
}
