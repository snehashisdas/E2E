using System;
using System.Collections.Generic;

namespace BocadUITestsSolution.ObjectRepos
{
    public class Locators
    {
        //Login --> Credentials

        public const string Win_Login = "AVEVA Login";
        public const string TxtBx_UserName = "cmbUser";
        public const string TxtBx_Password = "txtPassword";
        public const string Btn_StrcuturalDesign = "E3D Structural Design";


        //New Job --> Creation
        public const string Win_MainWindow = "MainWindow";
        public const string LstItm_NewJob   = "New Job";
        public const string TxtBx_JobName = "txtEditJobNameValue";
        public const string Btn_Create = "btnCreateJob";


        //Create Grid --> Controls
        public const string Win_CreateGrid = "Create Grid";
        public const string Btn_Ok = "OK";

        //Select view
        public const string Win_ChangeMainView = "Change Main View";
        public const string Lst_Axis1 = "Grid_0_1_AXIS_1";

        //select perspective view
        public const string ViewTabID = "AVEVA.Bocad.TabView";
        public const string PersepectiveViewName = "Perspective";
        public const string PersRepresent_Winname = "Perspective Representations";
        public const string PerspectiveViewTab_Name= "GloPers/Maximum/M1:50";

        //Create Profile 
        public const string CreateTab_ID = "AVEVA.Bocad.TabCreate";
        public const string CreateProfBtn_ID = "Segment Button";
        public const string CreateProfWin_ID = "[Group : Aveva.Bocad.Create.Members Tools] Tool : Aveva.Bocad.Create.Members.Profile - Index : 0 ";

        public static Dictionary<String, String> ab_Login_Form_Username = new Dictionary<String, String>()
        {
            { "ID","cmbUser"},
            { "NAME","GRIDWL BOCAD_GRIDS "},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> ab_Login_Form_Password = new Dictionary<String, String>()
        {
            { "ID","txtPassword"},
            { "NAME","GRIDWL BOCAD_GRIDS "},
            { "CLASS_NAME",""}
        };

        #region AVEVA BOCAD
        #region Login Form
        public static Dictionary<string, string> ab_Login_Form = new Dictionary<string, string>()
        {
            {"ID","LoginEx"},
            {"NAME",""},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.27a2811_r9_ad1"}
        };
        public static Dictionary<string, string> ab_Login_ProjectTitle_Win = new Dictionary<string, string>()
        {
            {"ID","projectsTile"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> ab_Login_ProjectTitle_NextBtn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","No Projects available. Please contact your system administrator."},
            {"CLASS_NAME","WindowsForms10.BUTTON.app.0.329445b_r9_ad1"}
        };
        public static Dictionary<String, String> ab_LoginProjectSearch_Panel = new Dictionary<String, String>()
        {
            { "ID","pnlProjectOptions"},
            { "NAME",""},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> ab_LoginProjectSearch = new Dictionary<String, String>()
        {
            { "ID","txtSearchText"},
            { "NAME","lblSearchResults"},
            { "CLASS_NAME","WindowsForms10.EDIT.app.0.329445b_r9_ad1"}
        };
        public static Dictionary<String, String> ab_SearchButton = new Dictionary<string, string>()
        {
            { "ID","btnSearch" },
            { "NAME","" },
            { "CLASS_NAME","WindowsForms10.BUTTON.app.0.329445b_r9_ad1" }
            };

        public static Dictionary<string, string> ab_Login_Form_Projectselection = new Dictionary<string, string>()
        {
            {"ID","BSP"},
            {"NAME","BSP"},
            {"CLASS_NAME","WindowsForms10.BUTTON.app.0.329445b_r9_ad1"}
        };


        public static Dictionary<string, string> ab_Login_Form_ParentWindow = new Dictionary<string, string>()
        {
            {"ID","loginCredentialsPanel"},
            {"NAME",""},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.329445b_r9_ad1"}
        };


        public static Dictionary<string, string> ab_Login_Form_User_Parent_Window = new Dictionary<string, string>()
        {
            {"ID","cmbUser"},
            {"NAME",""},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.329445b_r9_ad1"}
        };



        public static Dictionary<string, string> ab_Login_Form_UserLabel = new Dictionary<string, string>()
        {
            {"ID","lblUser"},
            {"NAME","User"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> ab_Login_Form_Username1 = new Dictionary<string, string>()
        {
            {"ID","cmbUser_EmbeddableTextBox"},
            {"NAME",""},
            {"CLASS_NAME","WindowsForms10.EDIT.app.0.329445b_r9_ad1"}
        };


        public static Dictionary<string, string> ab_Login_Form_Password1 = new Dictionary<string, string>()
        {
            {"ID","txtPassword"},
            {"NAME",""},
            {"CLASS_NAME","WindowsForms10.EDIT.app.0.329445b_r9_ad1"}
        };
        public static Dictionary<string, string> ab_Login_Form_MDB = new Dictionary<string, string>()
        {
             { "ID","cmbMDB" },
            { "NAME","" },
            { "CLASS_NAME","WindowsForms10.Window.8.app.0.329445b_r9_ad1" }
        };


        public static Dictionary<string, string> ab_Login_Form_MDB_Label = new Dictionary<string, string>()
        {
            {"ID","mdbLabel"},
            {"NAME","User"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> ab_Login_Form_DateStamp_Parent_Window = new Dictionary<string, string>()
        {
            {"ID","cmbStamp"},
            {"NAME",""},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.329445b_r9_ad1"}
        };

        public static Dictionary<string, string> ab_Login_Form_DateStamp_Label = new Dictionary<string, string>()
        {
            {"ID","lblStamp"},
            {"NAME","User"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> ab_Login_Form_DropDownButton = new Dictionary<string, string>()
        {
            {"ID","[Editor] dropdown button"},
            {"NAME",""},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.329445b_r9_ad1"}
        };

        public static Dictionary<string, string> ab_Login_Form_SelectFrom_Dropdown = new Dictionary<string, string>()
        {
             { "ID","ComboDropDownControl" },
            { "NAME","" },
            { "CLASS_NAME","WindowsForms10.Window.8.app.0.329445b_r9_ad1" }
        };



        public static Dictionary<string, string> ab_Login_Form_Detail_icon = new Dictionary<string, string>()
        {
            {"ID","ShortName"},
            {"NAME","Detail"},
            {"CLASS_NAME","WindowsForms10.STATIC.app.0.329445b_r9_ad1"}
        };

        public static Dictionary<string, string> ab_Login_Form_Verify = new Dictionary<string, string>()
        {
            {"ID","BackStage"},
            {"NAME","ribbon"},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.afceb_r9_ad1"}
        };
        #endregion

        #region job form       

        #region Job form Close
        public static Dictionary<string, string> ab_job_Form_Close = new Dictionary<string, string>()
        {

            { "ID","Close"},
            {"NAME","Close"},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.afceb_r9_ad1"}
        };
        public static Dictionary<String, String> ab_job_Form_Close_wrtco = new Dictionary<String, String>()
        {
            { "X","1912" },
            { "Y","15" },
        };
        public static Dictionary<String, String> ab_job_Form_Close_Yes_Btn = new Dictionary<String, String>()
        {
            { "X","900" },
            { "Y","560" },
        };
        public static Dictionary<String, String> ab_job_Form_Close_No_Btn = new Dictionary<String, String>()
        {
            { "X","980" },
            { "Y","560" },
        };
        public static Dictionary<String, String> ab_job_Form_Close_Final_No_Btn = new Dictionary<String, String>()
        {
            { "X","1022" },
            { "Y","550" },
        };
        #endregion

        #region job form open
        public static Dictionary<string, string> ab_job_Form_JobBox = new Dictionary<string, string>()
        {
            { "ID","listBoxJobs"},
            {"NAME",""},
            {"CLASS_NAME","ComboLBox"}
        };
        public static Dictionary<String, String> ab_jobOpen_Form_OpenJob_btn_wrtco = new Dictionary<String, String>()
        {
            { "X","1200" },
            { "Y","710" },
        };
        public static Dictionary<string, string> ab_jobOpen_Form_ElementClaimed_MessageBoxWin = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Element Claimed by other User!"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> ab_jobOpen_Form_ElementClaimed_MessageBox_OK_btn = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","OK"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> ab_jobOpen_Form_setphaseWin = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Set phase"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> ab_jobOpen_Form_setphaseWin_Close_Btn = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Close"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> ab_jobOpen_Form_ChangephaseWin = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Change/Set Phase"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> ab_jobOpen_Form_ChangephaseWin_Close_Btn = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Close"},
            {"CLASS_NAME",""}
        };
        #endregion

        #region Grid
        public static Dictionary<string, string> createGrid_MainWindow = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Create Grid"},
            {"CLASS_NAME","Qt5QWindowIcon"}
        };
        public static Dictionary<string, int> createGrid_X_Value_wrtco = new Dictionary<string, int>()
        {
            { "X",1430 },
            { "Y",307 },
        };
        public static Dictionary<string, int> createGrid_Y_Value_wrtco = new Dictionary<string, int>()
        {
            { "X",1430 },
            { "Y",389 },
        };
        public static Dictionary<string, int> createGrid_Z_Value_wrtco = new Dictionary<string, int>()
        {
            { "X",1430 },
            { "Y",460 },
        };
        public static Dictionary<string, int> createGrid_LevelName_wrtco = new Dictionary<string, int>()
        {
            { "X",1430 },
            { "Y",510 },
        };
        #endregion

        #region View
        public static Dictionary<string, string> view_ChangeMainView_Window = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Change Main View"},
            {"CLASS_NAME","Qt5QWindowIcon"}
        };
        public static Dictionary<string, string> view_PersRepresent_Win= new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Perspective representations"},
            {"CLASS_NAME","Qt5QWindowIcon"}
        };
        public static Dictionary<string, string> view_Glopers_Maximum_Tab = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","GloPers/Maximum/M1:50"},
            {"CLASS_NAME","Qt5QWindowIcon"}
        };
        public static Dictionary<string, string> view_Axis1_Tab = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Grid_0_1_AXIS_1"},
            {"CLASS_NAME",""}
        };
        #endregion

        public static Dictionary<string, string> job_Form_Maximize = new Dictionary<string, string>()
        {
            {"ID","Maximize"},
            {"NAME","Maximize"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> job_Form_Minimize = new Dictionary<string, string>()
        {
            {"ID","Minimize"},
            {"NAME","Minimize"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> job_Form_Restore = new Dictionary<string, string>()
        {
            {"ID","Restore"},
            {"NAME","Restore"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> job_Form_DetailingWorld = new Dictionary<string, string>()
        {
            { "ID","comboBoxWorlds"},
            {"NAME",""},
            {"CLASS_NAME","WindowsForms10.COMBOBOX.app.0.1ca0192_r9_ad1"}
        };
        public static Dictionary<string, string> job_Form_DetailingWorld_wrto = new Dictionary<string, string>()
        {
            { "X","400" },
            { "Y","150" },

        };
        public static Dictionary<string, string> job_Form_DetailingWorld_List = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME",""},
            {"CLASS_NAME","ComboLBox"}
        };
        public static Dictionary<String, String> job_Form_NewJob_wrtco = new Dictionary<String, String>()
        {
            { "X","330" },
            { "Y","230" },
        };
        public static Dictionary<string, string> job_Form_NewJob = new Dictionary<string, string>()
        {

            { "ID",""},
            {"NAME","New Job"},
            {"CLASS_NAME",""}

        };
        public static Dictionary<string, string> job_Form_JobName = new Dictionary<string, string>()
        {
            { "ID","txtEditJobNameValue"},
            {"NAME",""},
            {"CLASS_NAME","WindowsForms10.EDIT.app.0.ea7f4a_r9_ad1"}
        };
        public static Dictionary<String, String> job_Form_JobName_wrtco = new Dictionary<String, String>()
        {
            { "X","730" },
            { "Y","190" },
        };
        public static Dictionary<string, string> job_Form_JobNumber = new Dictionary<string, string>()
        {

            { "ID","txtEditJobNumberValue"},
            {"NAME",""},
            {"CLASS_NAME","WindowsForms10.EDIT.app.0.1ca0192_r9_ad1"}

        };
        public static Dictionary<String, String> job_Form_JobNumber_wrtco = new Dictionary<String, String>()
        {
            { "X","750" },
            { "Y","220" },
        };
        public static Dictionary<string, string> job_Form_JobCreatebutton = new Dictionary<string, string>()
        {

            { "ID","btnCreateJob"},
            {"NAME","Create"},
            {"CLASS_NAME","WindowsForms10.BUTTON.app.0.1ca0192_r9_ad1"}

        };
        public static Dictionary<String, String> job_Form_JobCreatebutton_wrtco = new Dictionary<String, String>()
        {
            { "X","1190" },
            { "Y","710" },
        };
        public static Dictionary<String, String> job_Form_CreateGrid_OK_Btn = new Dictionary<String, String>()
        {
            { "X","1260" },
            { "Y","710" },
        };
        public static Dictionary<string, string> job_Form_Axis1_Btn = new Dictionary<string, string>()
        {

            { "ID",""},
            {"NAME","Grid_0_1_AXIS_1"},
            {"CLASS_NAME",""}

        };
        public static Dictionary<string, string> job_Form_SelectAxis_OKBtn = new Dictionary<string, string>()
        {

            { "ID",""},
            {"NAME","OK Enter"},
            {"CLASS_NAME",""}

        };
        public static Dictionary<String, String> job_Form_Axis1_Btn_wrtco = new Dictionary<String, String>()
        {
            { "X","1350" },
            { "Y","382" },
        };
        public static Dictionary<String, String> job_Form_Axis_OK_Btn = new Dictionary<String, String>()
        {
            { "X","1300" },
            { "Y","710" },
        };
        public static Dictionary<String, String> job_Form_CloseForm = new Dictionary<string, string>()
{

            { "ID","Close"},
            {"NAME",""},
            {"CLASS_NAME",""}
};
        public static Dictionary<string, string> job_Form_ExitButton = new Dictionary<string, string>()
        {

            { "ID","[Navigation Menu Items] Menu Item :  - Index : 14 "},
            {"NAME","Exit"},
            {"CLASS_NAME",""}

        };
        public static Dictionary<string, string> Application_Form_CloseConfirmButton = new Dictionary<string, string>()
        {

            { "ID","2952674"},
            {"NAME","Yes"},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.1ca0192_r9_ad1"}

        };
        public static Dictionary<string, string> Application_Form_GetWork = new Dictionary<string, string>()
        {

            { "ID","[Navigation Menu Items] Menu Item :  - Index : 2 "},
            {"NAME","Get Work"},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.1ca0192_r9_ad1"}

        };
        public static Dictionary<string, string> Application_RibbonButton = new Dictionary<string, string>()
        {

            { "ID","RibbonDisplayOptions"},
            {"NAME","RibbonDisplayOptions"},
            {"CLASS_NAME",""}

        };
        public static Dictionary<string, string> Job_RibbonTabs_Tool = new Dictionary<string, string>()
        {

            { "ID","Aveva.Bocad.TabTools"},
            {"NAME","Tools"},
            {"CLASS_NAME",""}

        };
        public static Dictionary<string, string> Job_LowerRibbonTabs_Command = new Dictionary<string, string>()
        {

            { "ID","[Group : Aveva.Bocad.Tools.GroupDisplay Tools] Tool : Aveva.Bocad.Tools.ButtonCommandWindow - Index : 0 s"},
            {"NAME","Command Window"},
            {"CLASS_NAME",""}

        };
        public static Dictionary<string, string> Job_MainWindow = new Dictionary<string, string>()
        {

            { "ID","MainWindow"},
            {"NAME","Project: BSP | ALL | User: SYSTEM [en] | AVEVA E3D Structural Design + Offshore"},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.1ca0192_r9_ad1"}

        };

        #endregion

        #region QuickAccess ToolBar
        //--------Save Btn and after Save-----------
        public static Dictionary<string, string> ToolBar_Save_Btn = new Dictionary<string, string>()
        {
            {"ID","[QuickAccessToolbar Tools] Tool : Aveva.Bocad.ProjectSaveWork - Index : 0 "},
            {"NAME","Save Work"},
            {"CLASS_NAME",""}
        };

        //-------Undo Btn and all after Undo--------
        public static Dictionary<string, string> ToolBar_Undo_Btn = new Dictionary<string, string>()
        {
            {"ID","[QuickAccessToolbar Tools] Tool : AVEVA.DesignGeneral.ButtonUndo - Index : 2 "},
            {"NAME","Undo"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> ToolBar_UndoConfirmation_Win = new Dictionary<string, string>()
        {
            {"ID","Aveva_UndoConfirmation"},
            {"NAME","UNDO"},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.1ca0192_r9_ad1"}
        };
        public static Dictionary<string, string> ToolBar_UndoConfirmation_Win_Ok_Btn = new Dictionary<string, string>()
        {
            {"ID","ok"},
            {"NAME","OK"},
            {"CLASS_NAME","WindowsForms10.BUTTON.app.0.1ca0192_r9_ad1"}
        };
        public static Dictionary<string, string> ToolBar_UndoConfirmation_Win_Cancel_Btn = new Dictionary<string, string>()
        {
            {"ID","Cancel"},
            {"NAME","Cancel"},
            {"CLASS_NAME","WindowsForms10.BUTTON.app.0.1ca0192_r9_ad1"}
        };

        //-------Redo Btn and all after Redo--------
        public static Dictionary<string, string> ToolBar_Redo_Btn = new Dictionary<string, string>()
        {
            {"ID","[QuickAccessToolbar Tools] Tool : AVEVA.DesignGeneral.ButtonRedo - Index : 4 "},
            {"NAME","Redo"},
            {"CLASS_NAME",""}
        };
        #endregion

        #region Ribbon Tabs

        public static Dictionary<String, String> HomeTab = new Dictionary<String, String>()
        {
            { "ID","AVEVA.Bocad.TabHome"},
            { "NAME","Home"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> HomeTab_wrtco = new Dictionary<String, String>()
        {
            { "X","90" },
            { "Y","40" },
        };
        public static Dictionary<string, string> CreateTab = new Dictionary<string, string>()
        {

            { "ID","AVEVA.Bocad.TabCreate"},
            {"NAME","Create"},
            {"CLASS_NAME",""}

        };
        public static Dictionary<String, String> CreateTab_wrtco = new Dictionary<String, String>()
        {
            { "X","150" },
            { "Y","35" },
        };
        public static Dictionary<String, String> ModifyTab = new Dictionary<String, String>()
        {
            { "ID","AVEVA.Bocad.TabModify"},
            { "NAME","Modify"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> ModifyTab_wrtco = new Dictionary<String, String>()
        {
            { "X","220" },
            { "Y","35" },
        };
        public static Dictionary<String, String> PhaseAndGridTab_wrtco = new Dictionary<String, String>()
        {
            { "X","300" },
            { "Y","35" },
        };
        public static Dictionary<String, String> ViewTab = new Dictionary<String, String>()
        {
            { "ID","AVEVA.Bocad.TabView"},
            { "NAME","View"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> ViewTab_wrtco = new Dictionary<String, String>()
        {
            { "X","400" },
            { "Y","33" },
        };
        public static Dictionary<String, String> OffshoreTab_wrtco = new Dictionary<String, String>()
        {
            { "X","450" },
            { "Y","35" },
        };
        public static Dictionary<String, String> OutputTab_wrtco = new Dictionary<String, String>()
        {
            { "X","540" },
            { "Y","35" },
        };
        public static Dictionary<String, String> GraphicsTab_wrtco = new Dictionary<String, String>()
        {
            { "X","600" },
            { "Y","35" },
        };
        public static Dictionary<String, String> ToolsTab_wrtco = new Dictionary<String, String>()
        {
            { "X","680" },
            { "Y","35" },
        };
        public static Dictionary<String, String> ManageTab_wrtco = new Dictionary<String, String>()
        {
            { "X","750" },
            { "Y","35" },
        };
        public static Dictionary<string, string> AdminTab = new Dictionary<string, string>()
        {
            { "ID","Aveva.Bocad.TabAdmin"},
            {"NAME","Admin"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<String, String> AdminTab_wrtco = new Dictionary<String, String>()
        {
            { "X","815" },
            { "Y","40" },
        };
        public static Dictionary<String, String> ScriptingTab_wrtco = new Dictionary<String, String>()
        {
            { "X","890" },
            { "Y","35" },
        };
        public static Dictionary<String, String> ViewPortTab = new Dictionary<String, String>()

        {
             {"ID","Aveva.Bocad.TabViewport"},
            {"NAME","Viewport"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<String, String> ViewPortTab_wrtco = new Dictionary<String, String>()

        {
            { "X","960" },
            { "Y","35" },
        };
        public static Dictionary<String, String> MAXIMIZE_wrtco = new Dictionary<String, String>()
        {
            { "X","977" },
            { "Y","20" },
        };
        public static Dictionary<string, string> ThreeDViewTab = new Dictionary<string, string>()
        {

            { "ID","AVEVA.Design.Tab3DView"},
            {"NAME","3D View"},
            {"CLASS_NAME",""}

        };
        public static Dictionary<string, string> ClearCanvas_Btn = new Dictionary<string, string>()
        {
            { "ID","[TabItemAreaToolbar Tools] Tool : AVEVA.CAF.ClearCanvas - Index : 0 "},
            {"NAME","Clear Canvas"},
            {"CLASS_NAME",""}
        };
        #endregion

        #region Lower Ribbon Tabs
        #endregion
        #region Home 

        public static Dictionary<String, String> Home_tab = new Dictionary<String, String>()
        {
            { "ID","AVEVA.Bocad.TabHome"},
            { "NAME","Home"},
            { "CLASS_NAME",""}
        };

        public static Dictionary<String, String> Home_Points_Win = new Dictionary<String, String>()
        {
            { "ID","Group : Aveva.Bocad.Home.Points"},
            { "NAME","Points"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Points_DropDown_Btn = new Dictionary<String, String>()
        {
            { "ID","DropDown"},
            { "NAME","Drop Down"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Points_PointFromMember = new Dictionary<String, String>()
        {
            { "ID","GalleryTool Item : Aveva.Bocad.Home.Points.PointsFromMember - Index : 31 "},
            { "NAME",""},
            { "CLASS_NAME",""}
        };
           //Add Points
        public static Dictionary<String, String> Home_Points_Add = new Dictionary<String, String>()
        {
            { "ID","GalleryTool Item : Aveva.Bocad.Home.Points.Add - Index : 0 "},
            { "NAME",""},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Points_AddPoints_Win = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Add points"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Points_AddPoints_Win_OK_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };
        //Divide Line
        public static Dictionary<String, String> Home_Points_DivideLine = new Dictionary<String, String>()
        {
            { "ID","GalleryTool Item : Aveva.Bocad.Home.Points.DivideLine - Index : 25 "},
            { "NAME",""},
            { "CLASS_NAME",""}
        };
        
        //cutinhalf

        public static Dictionary<String, String> Home_Points_cutinhalf = new Dictionary<String, String>()
        {
            { "ID","GalleryTool Item : Aveva.Bocad.Home.Points.CutInHalf - Index : 24 "},
            { "NAME",""},
            { "CLASS_NAME",""}
        };


        public static Dictionary<String, String> Home_Points_DivideLine_Win = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Divide line"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Points_DivideLine_Win_Ok_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Points_DivideLine_Win_ZCoordinate_ChkBx = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","With Z coordinates"},
            { "CLASS_NAME",""}
        };
        //Copy-Move-Mirror
        public static Dictionary<String, String> Home_Copy_Btn = new Dictionary<String, String>()
        {
            { "ID","[Group : AVEVA.Home.GroupClipboard Tools] Tool : Aveva.Bocad.Home.Position.Copy - Index : 0 "},
            { "NAME","Copy"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Copy_ViaDistance_Btn = new Dictionary<String, String>()
        {
            { "ID","[Copy Items] Menu Item :  - Index : 0 "},
            { "NAME","Copy via Distance"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Copy_ViaPoints_Btn = new Dictionary<String, String>()
        {
            { "ID","[Copy Items] Menu Item :  - Index : 1 "},
            { "NAME","Copy via Points"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Copy_ViaAngle_Btn = new Dictionary<String, String>()
        {
            { "ID","[Copy Items] Menu Item :  - Index : 2 "},
            { "NAME","Copy via Angle"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Copy_ViaDivision_Btn = new Dictionary<String, String>()
        {
            { "ID","[Copy Items] Menu Item :  - Index : 3 "},
            { "NAME","Copy via Division"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Move_Btn = new Dictionary<String, String>()
        {
            { "ID","[Group : AVEVA.Home.GroupClipboard Tools] Tool : Aveva.Bocad.Home.Position.Move - Index : 1 "},
            { "NAME","Move"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_Mirror_Btn = new Dictionary<String, String>()
        {
            { "ID","[Group : AVEVA.Home.GroupClipboard Tools] Tool : Aveva.Bocad.Home.Position.Mirror - Index : 2 "},
            { "NAME","Mirror"},
            { "CLASS_NAME",""}
        };
        //copy via dimension win
        public static Dictionary<String, String> Home_CopyViaDimension_Win = new Dictionary<String, String>()
        {
            { "ID","Qt5QWindowIcon"},
            { "NAME","Copy via dimension"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_CopyViaDimension_Win_OK_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };

        //Clashing Member
        public static Dictionary<String, String> Home_ClashingMember_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Clashing Member"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_ClashingMember_CollidingMember_Win = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Colliding members"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_ClashingMember_CollidingMember_Win_ListRadio_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","List"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_ClashingMember_CollidingMember_Win_StartListRadio_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Start list only between eachother"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_ClashingMember_CollidingMember_Win_Ok_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };
        //clashing member start list
        public static Dictionary<String, String> Home_ClashingMember_CollidingMember_Win_StartList_DropDown = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Down"},
            { "CLASS_NAME",""}
        };
        public static string startList_CompleteProject = "Complete project";
        public const string startList_AsPicked = "As picked";
        public static string startList_Assemblies = "Assemblies";
        public const string startList_Phase = "Phase";

        //Member Without Partners
        public static Dictionary<String, String> Home_MemberWithoutPartners_Btn = new Dictionary<String, String>()
        {
            { "ID","[Group : Aveva.Home.Check Tools] Tool : Aveva.Bocad.Tools.CheckMemberWOPartners - Index : 1 "},
            { "NAME","Member without Partners"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_MemberWithoutPartners_Win = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Members without partner"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_MemberWithoutPartners_Win_startListDropDown_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME"," Down"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Home_MemberWithoutPartners_Win_Ok_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };

        //Display group

        public static Dictionary<String, String> Home_Display_group = new Dictionary<String, String>()
        {
            { "ID","Group : Aveva.Bocad.Home.GroupDisplay"},
            { "NAME","Display"},
            { "CLASS_NAME",""}
        };

        //Comments

        public static Dictionary<String, String> Home_Display_group_Comments = new Dictionary<String, String>()
        {
            { "ID","[Group : Aveva.Bocad.Home.GroupDisplay Tools] Tool : Aveva.Comment.StateButton - Index : 0"},
            { "NAME","Comments"},
            { "CLASS_NAME",""}
        };

        //Properties

        public static Dictionary<String, String> Home_Display_group_Properties = new Dictionary<String, String>()
        {
            { "ID","[Group : Aveva.Bocad.Home.GroupDisplay Tools] Tool : Aveva.Bocad.Home.StateButtonPropertyGrid - Index : 1"},
            { "NAME","Properties"},
            { "CLASS_NAME",""}
        };

        //Attributes

        public static Dictionary<String, String> Home_Display_group_Attributes = new Dictionary<String, String>()
        {
            { "ID","[Group : Aveva.Bocad.Home.GroupDisplay Tools] Tool : Aveva.Bocad.Home.StateAttributesList - Index : 2"},
            { "NAME","Attributes"},
            { "CLASS_NAME",""}
        };

        //Information Group

        public static Dictionary<String, String> Home_Information_group = new Dictionary<String, String>()
        {
            { "ID","Group : Aveva.Bocad.Home.Information"},
            { "NAME","Information"},
            { "CLASS_NAME",""}
        };

        //Member dropdown

        public static Dictionary<String, String> Home_Information_group_Member_dropdown = new Dictionary<String, String>()
        {
            { "ID","DropDown Arrow"},
            { "NAME","Member"},
            { "CLASS_NAME",""}
        };

        //Member parent

        public static Dictionary<String, String> Home_Information_group_Member_button_parent = new Dictionary<String, String>()
        {
            { "ID","[Group : Aveva.Bocad.Home.Information Tools] Tool : Aveva.Bocad.Home.Info.Member - Index : 0 "},
            { "NAME","Member"},
            { "CLASS_NAME",""}
        };

        //Member information

        public static Dictionary<String, String> Home_Information_group_Member_button_info = new Dictionary<String, String>()
        {
            { "ID","Segment Button"},
            { "NAME","Member"},
            { "CLASS_NAME",""}
        };



        #endregion

        #region Create 

        public static Dictionary<string, string> Create_Prof_Btn = new Dictionary<string, string>()
        {
            {"ID","Segment Button"},
            {"NAME","Profile"},
            {"CLASS_NAME",""}
        };

        //copy defaults from existing members

        public static Dictionary<string, string> Create_Prof_copy_defaults = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Profiles Tools] Tool : Aveva.Bocad.Create.Profiles.ButtonSteelworkSameProfileSetting - Index : 19 "},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        
        //Create tab button

        public static Dictionary<string, string> Create_tab_button = new Dictionary<string, string>()
        {
            {"ID","AVEVA.Bocad.TabCreate"},
            {"NAME","Create"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Prof_Specification_EditField = new Dictionary<string, string>()
        {
            {"ID","[Editor] Edit Area"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };

        #region concrete_Foundation in Perspective
        public static Dictionary<string, string> Create_Concrete_Btn = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Members Tools] Tool : Aveva.Bocad.Create.Members.Concrete - Index : 8 "},
            {"NAME","Concrete"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Concrete_Foundation_Btn = new Dictionary<string, string>()
        {
            {"ID","[Concrete Items] Menu Item :  - Index : 3 "},
            {"NAME","Foundation"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Concrete_Foundation_SingleBase_MainWin = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Single base"},
            {"CLASS_NAME","Qt5QWindowIcon"}
        };
        public static Dictionary<string, string> Create_Concrete_Foundation_SingleBase_Ok_Btn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","OK"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<String, int> Create_Concrete_Foundation_Position_midPoint = new Dictionary<String, int>()
        {
            { "X",527 },
            { "Y",285 },
        };
        public static Dictionary<String, int> Create_Concrete_Foundation_Position_Y_value = new Dictionary<String, int>()
        {
            { "X",600 },
            { "Y",280 },
        };
        public static Dictionary<String, int> Create_Concrete_Foundation_Position_X_value = new Dictionary<String, int>()
        {
            { "X",550 },
            { "Y",370 },
        };

        public static Dictionary<String, int> Create_Concrete_Foundation_Dimension_midPoint = new Dictionary<String, int>()
        {
            { "X",477 },
            { "Y",534 },
        };
        public static Dictionary<String, int> Create_Concrete_Foundation_Dimension_value = new Dictionary<String, int>()
        {
            { "X",615 },
            { "Y",555 },
        };
        #endregion

        #region Profile Creation

        public static Dictionary<string, string> Create_Prof_Specification_Cmbx = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Profiles Tools] Tool : Aveva.Bocad.Create.Profiles.SectionSpecification - Index : 0 "},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Prof_Specification_dropDown = new Dictionary<string, string>()
        {
            {"ID","[Editor] dropdown button"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Prof_Specification_dropDown_wrtCo = new Dictionary<string, string>()
        {
            { "X","1436" },
            { "Y","67" },
        };
        public static Dictionary<string, string> Create_Prof_Type_Cmbx= new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Profiles Tools] Tool : Aveva.Bocad.Create.Profiles.SectionGType - Index : 1 "},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Prof_Name_Cmbx = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Profiles Tools] Tool : Aveva.Bocad.Create.Profiles.SectionProfile - Index : 2 "},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Prof_Designation_Cmbx = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Profiles Tools] Tool : Aveva.Bocad.Create.Profiles.ClassPanel - Index : 4 "},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Prof_OrientationView_Btn = new Dictionary<string, string>()
        {
            {"ID","btn_CreationView"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        //Profile Orientation Point
        public static Dictionary<string, string> Create_Prof_TopLeft_Btn = new Dictionary<string, string>()
        {
            {"ID","btn_CreationView"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Prof_TopCenter_Btn = new Dictionary<string, string>()
        {
            {"ID","btn_CreationView"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Prof_TopRight_Btn = new Dictionary<string, string>()
        {
            {"ID","btn_CreationView"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };

        //Copy Defaults from Existing Profile

        public static Dictionary<string, string> Create_Prof_Copy_Defaults_from_Existing_Profile = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Profiles Tools] Tool : Aveva.Bocad.Create.Profiles.ButtonSteelworkSameProfileSetting - Index : 19"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };

        //Apply Defaults to Selected Profiles

        public static Dictionary<string, string> Create_Prof_Apply_Defaults_to_Selected_Profiles = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Profiles Tools] Tool : Aveva.Bocad.Create.Profiles.ButtonSteelworkApplyDefaultProperties - Index : 20"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };


        #endregion

        #region Plate Creation
        public static Dictionary<string, string> Create_Plate_Btn = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Members Tools] Tool : Aveva.Bocad.Create.Members.Plate - Index : 1 "},
            {"NAME","Concrete"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_PlateForm_Win = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Plate"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_PlateForm_Profil_Switch = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Profil"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Plate_ProfileListOutline_Win = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Profile list outline plate"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Plate_ProfileListOutline_Win_OKBtn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","OK Enter"},
            {"CLASS_NAME",""}
        };
        #endregion

        #region Hole Creation on Plate
        public static Dictionary<string, string> Create_Hole_Btn = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Connections Tools] Tool : Aveva.Bocad.Create.Connections.Holes.HoleThread - Index : 2 "},
            {"NAME","Hole/Thread/..."},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Hole_Rectangle_Win = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Hole Thread Length Rectangle Hole"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Hole_Rectangle_Win_OK_Btn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","OK"},
            {"CLASS_NAME",""}
        };
        #endregion

        #region Weld Creation
        public static Dictionary<string, string> Create_Weld_Btn = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Connections Tools] Tool : Aveva.Bocad.Create.Connections.Weld.Automatic - Index : 3 "},
            {"NAME","Automatic Weld"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Weld_AutomaticWeld_Win = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Automatic Weld"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Create_Weld_AutomaticWeld_Win_OK_Btn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","OK"},
            {"CLASS_NAME",""}
        };
        #endregion

        #region Macro Explorer 
        public static Dictionary<string, string> MacroExplorer_Btn = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Create.Construct Tools] Tool : Aveva.Bocad.Home.Construct.MacroManager.MacroExplorer - Index : 0 "},
            {"NAME","Macro Explorer"},
            {"CLASS_NAME",""}   
        };
        public static Dictionary<string, string> MacroExplorer_DropDownArrow = new Dictionary<string, string>()
        {
            {"ID","DropDown Arrow"},
            {"NAME","Macro Explorer"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> MacroExplorer_SegmentBtn = new Dictionary<string, string>()
        {
            {"ID","Segment Button"},
            {"NAME","Macro Explorer"},
            {"CLASS_NAME",""}
        };

        //Macro Explorer EditJoint Window
        public static Dictionary<string, string> MacroExplorer_EditJoint_win = new Dictionary<string, string>()
        {
            {"ID","Qt5QWindowIcon"},
            {"NAME","Edit < Joint"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> MacroExplorer_EditJoint_win_Stiffner = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Stiffeners"},
            {"CLASS_NAME",""}
        };

        //Bolts Related Locators
        public static Dictionary<string, string> MacroExplorer_EditJoint_win_BoltsBtn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Bolts"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> MacroExplorer_EditJoint_win_BoltsBtn_GeometryBtn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Geometry"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> MacroExplorer_EditJoint_win_OKBtn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","OK"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> MacroExplorer_EditJoint_win_RedoBtn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Redo"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> MacroExplorer_EditJoint_win_UndoOKBtn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Undo + OK"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> MacroExplorer_AdminBox_Btn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Admin box"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> MacroExplorer_AdminBox_Pickrequests_radioBtn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Pickrequests"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> MacroExplorer_UserBox_Btn = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","User box"},
            {"CLASS_NAME",""}
        };

        #endregion

        #endregion

        #region Modify 

        public static Dictionary<String, String> Modify_Length_Btn = new Dictionary<String, String>()
        {
            { "ID","[Group : Aveva.Bocad.Modify.Members Tools] Tool : Aveva.Bocad.Modify.Members.Length - Index : 0 "},
            { "NAME","Length"},
            { "CLASS_NAME",""}
        };
        //Length Modification 
        public static Dictionary<String, String> Modify_Length_LengthMod_Win = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Length Modification"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Modify_Length_LengthMod_AdaptMember = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Adapt to a member "},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Modify_Length_LengthMod_OK_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };
        #endregion
        #region Phase and Grid 
        #endregion

        #region PROJECT
        
        //Project tab button

        public static Dictionary<String, String> project_tab_but = new Dictionary<String, String>()
        {
            { "ID","Application Menu Button"},
            { "NAME","PROJECT"},
            { "CLASS_NAME",""}
        };

        //Navigation window in Project menu tab

        public static Dictionary<String, String> project_tab_but_navigation_win = new Dictionary<String, String>()
        {
            { "ID","Navigation Menu"},
            { "NAME","PROJECT"},
            { "CLASS_NAME",""}
        };
        
        //Title bar boview window

        public static Dictionary<String, String> project_tab_but_navigation_win_boview_win_titlebar = new Dictionary<String, String>()
        {
            { "ID","TitleBar"},
            { "NAME",""},
            { "CLASS_NAME",""}
        };


        #region BOVIEW

        //Select ass from names

        public static Dictionary<string, string> project_tab_but_navigation_win_boview_win_select_ass = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","ass"},
            {"CLASS_NAME",""}
        };

        //Select drawing from ass folder

        public static Dictionary<string, string> project_tab_boview_win_select_ass_select_drawing = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","p0100001.bmf_"},
            {"CLASS_NAME",""}
        };

        //Select second drawing from ass folder

        public static Dictionary<string, string> project_tab_boview_win_select_ass_select_secdrawing = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","p0100003.bmf_"},
            {"CLASS_NAME",""}
        };


        //Select shop from names

        public static Dictionary<string, string> project_tab_but_navigation_win_boview_win_select_shop = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","shop"},
            {"CLASS_NAME",""}
        };

        //Select drawing from shop folder

        public static Dictionary<string, string> project_tab_boview_win_select_shop_select_drawing = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","s0100001.bmf_"},
            {"CLASS_NAME",""}
        };

        //Select second drawing from shop folder

        public static Dictionary<string, string> project_tab_boview_win_select_shop_select_secdrawing = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","s0100003.bmf_"},
            {"CLASS_NAME",""}
        };

        //close boview window

        public static Dictionary<string, string> project_tab_boview_win_close_button = new Dictionary<string, string>()
        {
            {"ID","Close"},
            {"NAME","Close"},
            {"CLASS_NAME",""}
        };


        //Boview from project navigation window 

        public static Dictionary<String, String> project_tab_but_navigation_win_boview = new Dictionary<String, String>()
        {
            { "ID","[Navigation Menu Items] Menu Item :  - Index : 7 "},
            { "NAME","Boview"},
            { "CLASS_NAME",""}
        };

        //maximize boview window

        public static Dictionary<String, String> project_tab_but_navigation_win_boview_win_maximize = new Dictionary<String, String>()
        {
            { "ID","Maximize-Restore"},
            { "NAME","Maximize"},
            { "CLASS_NAME",""}
        };

        //boview window

        public static Dictionary<String, String> project_tab_but_navigation_win_boview_win = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","AVEVA Bocad BoView (32.20181126) - en [32] [C:/AVEVA/bocad/Projects_3_2_2/BSP/boc_ALL/shekhar.verma/ZOUEKa/plots] - Printer settings"},
            { "CLASS_NAME",""}
        };

        //boview window

        public static Dictionary<String, String> project_tab_but_navigation_win_boview_win_again = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","AVEVA Bocad BoView (32.20181126) - en [32] "},
            { "CLASS_NAME",""}
        };

        #endregion

        #endregion


        #region View 
        //Perspective View 
        public static Dictionary<String, String> View_Perspective_Btn = new Dictionary<String, String>()
        {
            { "ID","[Group : Aveva.Bocad.View.Additional Tools] Tool : Aveva.Bocad.View.Additional.Perspective - Index : 2 "},
            { "NAME","Perspective"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> View_PersRepresent_OKbtn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> View_PersRepresent_Closebtn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Close"},
            { "CLASS_NAME",""}
        };

        //Detail View 
        public static Dictionary<String, String> View_Detail_btn = new Dictionary<String, String>()
        {
            { "ID","[Group : Aveva.Bocad.View.Additional Tools] Tool : Aveva.Bocad.View.Additional.Detail - Index : 1 "},
            { "NAME","Detail"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> View_Detail_ViewForm_Win = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Section View"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> View_Detail_ViewForm_Above = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Above "},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> View_Detail_ViewForm_Front = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","front "},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> View_Detail_ViewForm_Diemetry = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Dimetry "},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> View_Detail_ViewForm_Save_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Save"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> View_Detail_ViewForm_OK_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> View_Detail_ViewForm_Window_dropdown = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME"," Down"},
            { "CLASS_NAME",""}
        };

        public static Dictionary<String, String> View_Detail_ViewForm_Window_dropdown_viewtogetherinsinglewindow = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME"," Views together in a single new window"},
            { "CLASS_NAME",""}
        };

        public static Dictionary<String, String> View_Detail_ViewForm_Window = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME"," Section View"},
            { "CLASS_NAME","Qt5QWindowIcon"}
        };

        //Change view from bottom window

        public static Dictionary<String, String> View_btn = new Dictionary<String, String>()
{
{ "ID","AVEVA.Bocad.TabView"},
{ "NAME","View"},
{ "CLASS_NAME",""}
};
        public static Dictionary<String, String> ChangeView_btn = new Dictionary<String, String>()
{
{ "ID","[Group : Aveva.Bocad.View.Primary Tools] Tool : Aveva.Bocad.View.Primary.Change - Index : 0 "},
{ "NAME","Change"},
{ "CLASS_NAME",""}
};
        #endregion

        #region Offshore 
        #endregion
        #region Output 

        public static Dictionary<String, String> Output_menu_tab = new Dictionary<String, String>()
        {
            { "ID","AVEVA.Bocad.TabOutput"},
            { "NAME","Output"},
            { "CLASS_NAME",""}
        };

        //Advanced Marking button

        public static Dictionary<String, String> Output_menu_tab_advanced_marking_button = new Dictionary<String, String>()
        {
            { "ID","[Group : Aveva.Bocad.Output.Marking Tools] Tool : Aveva.Bocad.Output.Marking.AdvancedMarking - Index : 1 "},
            { "NAME","Advanced"},
            { "CLASS_NAME",""}
        };

        //Advanced Marking Window(subwindow)

        public static Dictionary<String, String> Output_menu_tab_advanced_marking_window = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Advanced marking"},
            { "CLASS_NAME","Qt5QWindowIcon"}
        };



        //More button in Advanced Marking window

        public static Dictionary<String, String> Output_advanced_marking_more_button = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","More"},
            { "CLASS_NAME",""}
        };

        //Type of Marking dropdown in Marking window

        public static Dictionary<String, String> Output_advanced_marking_more_typeofmarkingdropdown = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Down"},
            { "CLASS_NAME",""}
        };


        //Type of Marking dropdown in Marking window (Coordinates)

        public static Dictionary<String, String> Output_advanced_marking_more_typeofmarkingdropdown_coord = new Dictionary<String, String>()
        {
            { "X","602" },
            { "Y","80" },
        };

        //Complete bolts from dropdown in Marking window (Coordinates)

        public static Dictionary<String, String> Output_advanced_marking_more_typeofmarkingdropdown_compbolts_coord = new Dictionary<String, String>()
        {
            { "X","536" },
            { "Y","127" },
        };

        //ok button in Marking window (Coordinates)

        public static Dictionary<String, String> Output_advanced_marking_more_OKbutton_coord = new Dictionary<String, String>()
        {
            { "X","46" },
            { "Y","488" },
        };

        //Marking Window(subwindow)

        public static Dictionary<String, String> Output_menu_tab_marking_window = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","marking"},
            { "CLASS_NAME","Qt5QWindowIcon"}
        };


        //More button in Advanced Marking window (coordinates)

        public static Dictionary<String, String> Output_advanced_marking_more_button_coord = new Dictionary<String, String>()
        {
            { "X","583" },
            { "Y","352" },
        };

        //OK button in Advanced Marking window

        public static Dictionary<String, String> Output_advanced_marking_OK_button = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };

        //Advanced Marking button(coordinates)

        public static Dictionary<String, String> ab_Ribbon_Tools_advanced_marking_But_coord = new Dictionary<String, String>()
        {
            { "X","100" },
            { "Y","81" },
        };

        //OK button in Advanced Marking window (Coordinates)

        public static Dictionary<String, String> Output_advanced_marking_ok_button = new Dictionary<String, String>()
        {
           { "X","136" },
            { "Y","374" },
        };

        //Check box for Bolts in Marking window (coordinates)

        public static Dictionary<String, String> Output_advanced_marking_more_check_bolts = new Dictionary<String, String>()
        {
           { "X","48" },
            { "Y","91" },
        };
        //Select Bolts in  Marking window in Marking window

        public static Dictionary<String, String> Output_marking_select_bolts = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Bolts"},
            { "CLASS_NAME",""}
        };

        //Check box for Welds in Marking window (coordinates)

        public static Dictionary<String, String> Output_advanced_marking_more_check_welds = new Dictionary<String, String>()
        {
           { "X","48" },
            { "Y","112" },
        };

        //Select Bolts in  Marking window (coordinates)

        public static Dictionary<String, String> Output_advanced_marking_more_select_bolts = new Dictionary<String, String>()
        {
           { "X","100" },
            { "Y","88" },
        };

        //Select Welds in  Marking window (coordinates)

        public static Dictionary<String, String> Output_advanced_marking_more_select_welds = new Dictionary<String, String>()
        {
           { "X","96" },
            { "Y","110" },
        };


        //Unmark

        public static Dictionary<String, String> Output_Unmark_button = new Dictionary<String, String>()
        {
            { "ID","[Group : Aveva.Bocad.Output.Marking Tools] Tool : Aveva.Bocad.Output.Marking.Unmark - Index : 6 "},
            { "NAME","Unmark"},
            { "CLASS_NAME",""}
        };

        // Unmark window (subwindow)

        public static Dictionary<String, String> Output_Unmark_window = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Unmark"},
            { "CLASS_NAME","Qt5QWindowIcon"}
        };

        //OK in Unmark window (coordinates)

        public static Dictionary<String, String> Output_Unmark_window_ok_button_coord = new Dictionary<String, String>()
        {
           { "X","435" },
            { "Y","194" },
        };

        // OK button in Unmark window 

        public static Dictionary<String, String> Output_Unmark_window_ok_button = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };


        #region Nested Drawing
        public static Dictionary<String, String> Output_NestedDrawing_Win = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Nested drawings"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Output_NestedDrawing_Win_OpenCreateEditField = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Open/Create page"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> Output_NestedDrawing_Win_Ok_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<string, string> Model_View_btn = new Dictionary<string, string>()
{
{"ID","[Group : Aveva.Bocad.View.Additional Tools] Tool : Aveva.Bocad.View.Additional.MainView - Index : 5 "},
{"NAME","Model View"},
{"CLASS_NAME",""}
};
        public static Dictionary<string, string> Nested_representation_setting_btn = new Dictionary<string, string>()
{
{"ID","[Group : Aveva.Bocad.NestedDrawing.Representation Tools] Tool : Aveva.Bocad.View.RepresentationSettings - Index : 0 "},
{"NAME","Settings"},
{"CLASS_NAME",""}
};
        public static Dictionary<string, string> Nested_drawing_tab_btn = new Dictionary<string, string>()
               {
{"ID","Aveva.Bocad.TabNestedDrawing"},
{"NAME","Nested Drawing"},
{"CLASS_NAME",""}
};
        public static Dictionary<string, string> Nested_drawing_save_btn = new Dictionary<string, string>()
{
{"ID","[Group : Aveva.Bocad.NestedDrawing.File Tools] Tool : Aveva.Bocad.View.FileSave - Index : 0 "},
{"NAME","Save"},
{"CLASS_NAME",""}
};
        public static Dictionary<string, string> Output_tab = new Dictionary<string, string>()
{
{"ID","AVEVA.Bocad.TabOutput"},
{"NAME","Output"},
{"CLASS_NAME",""}
};
        public static Dictionary<string, string> Output_Nested_drawing_btn = new Dictionary<string, string>()
{
{"ID","[Group : Aveva.Bocad.Output.Drawing Tools] Tool : Aveva.Bocad.Output.Edit.NestedDrawing - Index : 1 "},
{"NAME","Nested Drawing"},
{"CLASS_NAME",""}
};
        public static Dictionary<string, string> Output_Nested_drawing_tab = new Dictionary<string, string>()
{
{"ID","Aveva.Bocad.TabNestedDrawing"},
{"NAME","Nested Drawing"},
{"CLASS_NAME",""}
};
        public static Dictionary<string, string> Nested_drawing_Copy_btn = new Dictionary<string, string>()
{
{"ID","[Group : Aveva.Bocad.NestedDrawing.Drawings Tools] Tool : Aveva.Bocad.NestedDrawing.CopyDrawing - Index : 2 "},
{"NAME","Nested Drawing"},
{"CLASS_NAME",""}
};
        #endregion


        #region Drawings

        //Automatic drawings button

        public static Dictionary<String, String> Output_Drawing_Automatic_button = new Dictionary<String, String>()
        {
            { "ID","[Group : Aveva.Bocad.Output.Drawing Tools] Tool : Aveva.Bocad.Output.Drawing.Automatic - Index : 0 "},
            { "NAME","Automatic"},
            { "CLASS_NAME",""}
        };

        //Create Automatic drawings window

        public static Dictionary<String, String> Output_Drawing_Automatic_drawing_win = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Create Automatic Drawings"},
            { "CLASS_NAME","Qt5QWindowIcon"}
        };

        //Execute button in Create Automatic drawings window

        public static Dictionary<String, String> Output_Drawing_Automatic_drawing_win_execute_button = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Execute"},
            { "CLASS_NAME",""}
        };

        //Close button in Create Automatic drawings window

        public static Dictionary<String, String> Output_Drawing_Automatic_drawing_win_close_button = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Close"},
            { "CLASS_NAME",""}
        };

        //Assembly from drawing types

        public static Dictionary<String, String> Output_Drawing_Automatic_drawing_win_select_assembly = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Assembly"},
            { "CLASS_NAME",""}
        };

        //Configuration assembly drawing window

        public static Dictionary<String, String> Output_Drawing_Automatic_Configuration_assembly_drawing_window = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Configuration assembly drawings"},
            { "CLASS_NAME","Qt5QWindowIcon"}
        };

        //Designation in Configuration assembly drawing window

        public static Dictionary<String, String> Output_Drawing_Automatic_Configuration_assembly_drawing_window_desig = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Designation "},
            { "CLASS_NAME",""}
        };

        //ok button in config assembly drawing window

        public static Dictionary<String, String> Output_Drawing_Automatic_Configuration_assembly_drawing_window_okbutton = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };

        //Frame window

        public static Dictionary<String, String> Output_Drawing_Automatic_Configuration_assembly_drawing_Paper_Frame_win = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Frame"},
            { "CLASS_NAME",""}
        };

        //ok button in Frame window

        public static Dictionary<String, String> Output_Drawing_Automatic_Configuration_assembly_drawing_Paper_Frame_win_okbut = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK Enter"},
            { "CLASS_NAME",""}
        };

        //SHOP Drawing

        //Select shop drawing from drawing types

        public static Dictionary<String, String> Output_Drawing_Automatic__select_shop = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Shop drawing"},
            { "CLASS_NAME",""}
        };

        //Configuration shop drawing window

        public static Dictionary<String, String> Output_Drawing_Automatic_Configuration_shop_drawing_window = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Configuration shop drawings"},
            { "CLASS_NAME","Qt5QWindowIcon"}
        };

        //ok button in config shop drawing window

        public static Dictionary<String, String> Output_Drawing_Automatic_Configuration_shop_drawing_window_okbutton = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","OK"},
            { "CLASS_NAME",""}
        };


        //NCDSTV drawings

        //Select NC-DSTC interface from drawing types tree
        public static Dictionary<String, String> Output_Drawing_Automatic_create_automatic_drawing_ncdstv = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","NC-DSTV interface"},
            { "CLASS_NAME",""}
        };

        #endregion

        #endregion
        #region Graphics 
        #endregion
        #region Tools 

        public static Dictionary<String, String> ab_Ribbon_Tools_CommandWindow_Button = new Dictionary<String, String>()
        {
            { "X","25" },
            { "Y","80" },
        };

        public static Dictionary<String, String> ab_Ribbon_Tools_toolstab_Button = new Dictionary<String, String>()
        {
            {"ID","Aveva.Bocad.TabTools"},
            {"NAME","Tools"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> ab_Ribbon_Tools_CommandWindow = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Command Window"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> ab_Ribbon_Tools_CommandWindow_Textbox = new Dictionary<string, string>()
        {
            {"ID","commandTextBox"},
            {"NAME","label1"},
            {"CLASS_NAME","WindowsForms10.EDIT.app.0.1ca0192_r9_ad1"}
        };

        public static Dictionary<string, string> ab_Ribbon_Tools_messageWindow_but = new Dictionary<string, string>()
        {
            {"ID","[Group : Aveva.Bocad.Tools.GroupDisplay Tools] Tool : Aveva.Bocad.Tools.MessageWindowVisibility - Index : 2 "},
            {"NAME","Message Window"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> ab_Ribbon_Tools_messagetab = new Dictionary<string, string>()
        {
            {"ID","TabItem Key Aveva.Core.Presentation.MessageWindow"},
            {"NAME","Messages"},
            {"CLASS_NAME",""}
        };
        #endregion
        #region Manage 
        #endregion


        #region Admin 
        public static Dictionary<string, string> Admin_ComputeWeight = new Dictionary<string, string>()
        {
            { "ID","[Group : Aveva.Bocad.Admin.Weight Tools] Tool : Aveva.Bocad.Home.Edit.MemberProperties.WeightCalculation - Index : 0 "},
            {"NAME","Compute Weight"},
            {"CLASS_NAME",""}
        };

        #region WeightCalculator
        public static Dictionary<string, string> WeightCalculator_Cmbx_EditingControl = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Editing Control"},
            {"CLASS_NAME","WindowsForms10.COMBOBOX.app.0.1ca0192_r9_ad1"}
        };
        //User Weight Attribute
        public static Dictionary<string, string> UserWeightAttribute_Row_0 = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","User Weight Attribule Row 0"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> UserWeightAttribute_Row_1 = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","User Weight Attribule Row 1"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> UserWeightAttribute_Row_2 = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","User Weight Attribule Row 2"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> UserWeightAttribute_Row_3 = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","User Weight Attribule Row 3"},
            {"CLASS_NAME",""}
        };

        //Operator Combobox Locators
        public static Dictionary<string, string> Operator_Row_0 = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Operators Row 0"},
            {"CLASS_NAME",""}
        };
        //Weight Attribute
        public static Dictionary<string, string> WeightAttribute_Row_0 = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Weight Attribule Row 0"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Real_Weight = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","DTRWGH (Real Weight)"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> User_Weight = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","DTRUWG (User Weight)"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Gross_Weight = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","DTWGHT (Gross Weight)"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Rubber_Weight = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","DTUWGH (Rubber Band Weight)"},
            {"CLASS_NAME",""}
        };
        //Setting User Input Value
        public static Dictionary<string, string> UserInput_Row_0 = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","User Input Row 0"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> WeightCalculator_Ok_Btn = new Dictionary<string, string>()
        {
            { "ID","btnSave"},
            {"NAME","Ok"},
            {"CLASS_NAME","WindowsForms10.BUTTON.app.0.1ca0192_r9_ad1"}
        };
        #endregion

        #endregion

        #region Scripting 
        #endregion
        #region Viewport 
        public static Dictionary<String, String> viewport_Extents = new Dictionary<String, String>()

        {
             {"ID","[Group : Aveva.Bocad.Viewport.Zoom Tools] Tool : Aveva.Bocad.View.ZoomExtents - Index : 0 "},
            {"NAME","Extents"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<String, String> viewport_Calculate = new Dictionary<String, String>()

        {
             {"ID","[Group : Aveva.Bocad.Viewport.Representation Tools] Tool : Aveva.Bocad.View.RepresentationCalculate - Index : 1 "},
            {"NAME","Calculate"},
            {"CLASS_NAME",""}
        };
        #endregion

        #region 3Dview

        //3D view menu tab

        public static Dictionary<string, string> canvas_view_menu_tab = new Dictionary<string, string>()
        {
            {"ID","AVEVA.Design.Tab3DView"},
            {"NAME","3D View"},
            {"CLASS_NAME",""}
        };

        #endregion
        #region Look
        public static Dictionary<string, string> Look = new Dictionary<string, string>()
        {
            { "ID","[Group : AVEVA.DesignView.GroupGraphicalDisplay Tools] Tool : AVEVA.DesignGeneral.GalleryLook - Index : 0 "},
            {"NAME","Look"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Look_Isometric_SW = new Dictionary<string, string>()
        {
            { "ID","GalleryTool Item : SW - Index : 0 "},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Look_Isometric_SE = new Dictionary<string, string>()
        {
            { "ID","GalleryTool Item : SE - Index : 1 "},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Look_Isometric_NE = new Dictionary<string, string>()
        {
            { "ID","GalleryTool Item : NE - Index : 2 "},
            {"NAME",""},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> Look_Isometric_NW = new Dictionary<string, string>()
        {
            { "ID","GalleryTool Item : NW - Index : 3 "},
            {"NAME",""},
            {"CLASS_NAME",""}
        };

        //Orthographic 

        public static Dictionary<String, String> Look_Orthographic_East_Button = new Dictionary<String, String>()
        {
            { "X","358" },
            { "Y","220" },
        };

        public static Dictionary<string, string> Look_Orthographic_subwin = new Dictionary<string, string>()
        {
            { "ID","[Look Items] Menu Item :  - Index : 0  Items"},
            {"NAME","Orthographic"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> Look_Orthographic_North = new Dictionary<string, string>()
        {
            { "ID","GalleryTool Item : N - Index : 4  "},
            {"NAME",""},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> Look_Orthographic_South = new Dictionary<string, string>()
        {
            { "ID","GalleryTool Item : S - Index : 5"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> Look_Orthographic_East = new Dictionary<string, string>()
        {
            { "ID","GalleryTool Item : E - Index : 6"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> Look_Orthographic_West = new Dictionary<string, string>()
        {
            { "ID","GalleryTool Item : W - Index : 7"},
            {"NAME",""},
            {"CLASS_NAME",""}
        };


        #endregion            

        #region Work Field

        #region Comment
        public static Dictionary<String, String> ab_WorkField_Comment_Add_Btn = new Dictionary<String, String>()
        {
            { "X","1890" },
            { "Y","370" },
        };
        public static Dictionary<String, String> ab_WorkField_Comment_CurrentElement = new Dictionary<String, String>()
        {
            { "X","1800" },
            { "Y","280" },
        };
        public static Dictionary<String, String> ab_WorkField_Comment_DTPROF_OK = new Dictionary<String, String>()
        {
            { "X","1660" },
            { "Y","315" },
        };
        public static Dictionary<String, String> ab_WorkField_Comment_NewThread_CommentTitle = new Dictionary<String, String>()
        {
            { "X","1610" },
            { "Y","220" },
        };
        public static Dictionary<String, String> ab_WorkField_Comment_NewThread_CommentBody = new Dictionary<String, String>()
        {
            { "X","1660" },
            { "Y","270" },
        };
        public static Dictionary<String, String> ab_WorkField_Comment_NewThread_SaveBtn = new Dictionary<String, String>()
        {
            { "X","1870" },
            { "Y","430" },
        };


        #endregion

        #region foundation in perspective view
        public static Dictionary<String, int> WorkField_PersFoundation_PointB1 = new Dictionary<String, int>()
        {
            { "X",690 },
            { "Y",828 },
        };
        public static Dictionary<String, int> WorkField_PersFoundation_PointB2 = new Dictionary<String, int>()
        {
            { "X",830 },
            { "Y",700 },
        };
        public static Dictionary<String, int> WorkField_PersFoundation_PointB3 = new Dictionary<String, int>()
        {
            { "X",960 },
            { "Y",575 },
        };
        public static Dictionary<String, int> WorkField_PersFoundation_PointA1 = new Dictionary<String, int>()
        {
            { "X",930 },
            { "Y",870 },
        };
        public static Dictionary<String, int> WorkField_PersFoundation_PointA2 = new Dictionary<String, int>()
        { 
            { "X", 1070},
            { "Y",740 },
        };
        public static Dictionary<String, int> WorkField_PersFoundation_PointA3 = new Dictionary<String, int>()
        {
            { "X",1204 },
            { "Y",614 },
        };
        #endregion


        public static Dictionary<String, String> WorkField_DefaultPoint = new Dictionary<String, String>()
        {
            { "X","1212" },
            { "Y","612" },
        };
        public static Dictionary<String, String> WorkField_ModelWorld_Btn = new Dictionary<String, String>()
        {
            { "ID","TabItem Key DesignExplorer"},
            { "NAME","Model Explorer"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> WorkField_Comment_Btn = new Dictionary<String, String>()
        {
            { "ID","TabItem Key Aveva.Comment.CommentList"},
            { "NAME","Comments"},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> WorkField_ModelWorldExplorer_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","Model WORL * "},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> WorkField_GridWorld_Btn = new Dictionary<String, String>()
        {
            { "ID","[Node] 0, [Node] 0"},
            { "NAME","GRIDWL BOCAD_GRIDS "},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> WorkField_BMFWorld_Btn = new Dictionary<String, String>()
        {
            { "ID","[Node] 0, [Node] 1"},
            { "NAME","BMFWRL BMFWLD "},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> WorkField_DTWorld_Btn = new Dictionary<String, String>()
        {
            { "ID","[Node] 0, [Node] 2"},
            { "NAME","DTWRLD DETWORLD_1 "},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> WorkField_DTPhase_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","DTPHSE 1 "},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> WorkField_DTProf1_Btn = new Dictionary<String, String>()
        {
            { "ID",""},
            { "NAME","DTPROF 1 "},
            { "CLASS_NAME",""}
        };
        public static Dictionary<String, String> WorkField_SaveWork = new Dictionary<String, String>()
        {
            { "X","35" },
            { "Y","17" },
        };
        public static Dictionary<String, String> WorkField_ProjectBtn = new Dictionary<String, String>()
        {
            { "X","30" },
            { "Y","40" },
        };
        public static Dictionary<String, String> WorkField_SaveWork_Btn = new Dictionary<String, String>()
        {
            { "X","45" },
            { "Y","115" },
        };

        //locators for views
        public static Dictionary<string, string> WorkField_newVerticalTab= new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","New Vertical Tab Group"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> WorkField_newHorizontalTab = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","New Horizontal Tab Group"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> WorkField_Close_Tab = new Dictionary<string, string>()
        {
            { "ID","257"},
            {"NAME","Close"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> WorkField_3DView_Tab = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","3D View(1) - Drawlist(1)"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> WorkField_DetailView_Tab = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","name_Nested drawing/M1:5/tv135.8/th-591.7"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> WorkField_TabClose_Btn = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","TabCloseButton"},
            {"CLASS_NAME",""}
        };

        //Save View with Name
        public static Dictionary<string, string> WorkField_TabClose_Save_Win = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Selection"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> WorkField_TabClose_Save_Yes_Btn = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Yes Enter"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> WorkField_TabClose_Save_No_Btn = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","No"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> WorkField_TabClose_Save_Cancel_Btn = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Cancel"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> FileName_Win = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","File name"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> FileName_Edit_Field = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","File name: Alt+n"},
            {"CLASS_NAME",""}
        };
        public static Dictionary<string, string> FileName_Save_Btn = new Dictionary<string, string>()
        {
            { "ID",""},
            {"NAME","Save Enter"},
            {"CLASS_NAME",""}
        };
        #endregion

        #region Right Pane Window

        //Property grid window
        public static Dictionary<string, string> LPW_Model_Explorer_Tab_Win_Grd_world_refgrd = new Dictionary<string, string>()
                    {
{"ID","[Node] 0, [Node] 0, [Node] 0"},
{"NAME","REFGRD 1"},
{"CLASS_NAME",""}
};
        public static Dictionary<string, string> RPW_Property_Grid_Tab = new Dictionary<string, string>()
        {
            {"ID","TabItem Key 3e051d4c-2d0e-4698-b109-d6b9f0b42a30"},
            {"NAME","Properties"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> RPW_Property_Grid_Tab_Win = new Dictionary<string, string>()
        {
            {"ID","329488"},
            {"NAME","Properties Window"},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.1ca0192_r9_ad1"}
        };

        public static Dictionary<string, string> RPW_Property_Grid_Tab_Win_Profile = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Profile"},
            {"CLASS_NAME",""}
        };
        //Edit Profile

        public static Dictionary<string, string> RPW_Property_Grid_Tab_Win_Profile_edit = new Dictionary<string, string>()
        {
            {"ID","3934238"},
            {"NAME","Profile"},
            {"CLASS_NAME","WindowsForms10.EDIT.app.0.1ca0192_r9_ad1"}
        };

        //Designation in Property grid

        public static Dictionary<string, string> RPW_Property_Grid_Tab_Win_Designation = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Designation"},
            {"CLASS_NAME",""}
        };

        //Edit Designation in Property grid

        public static Dictionary<string, string> RPW_Property_Grid_Tab_Win_Designation_edit = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Designation"},
            {"CLASS_NAME",""}
        };
        
        //Material Grade in Property grid

        public static Dictionary<string, string> RPW_Property_Grid_Tab_Win_Material_Grade = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Material Grade"},
            {"CLASS_NAME",""}
        };

        //Edit Material Grade in Property grid

        public static Dictionary<string, string> RPW_Property_Grid_Tab_Win_Material_Grade_edit = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Material Grade"},
            {"CLASS_NAME",""}
        };

        // Member Family  in Property grid

        public static Dictionary<string, string> RPW_Property_Grid_Tab_Win_Member_Family = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Member Family"},
            {"CLASS_NAME",""}
        };

        //Edit Member Family  in Property grid

        public static Dictionary<string, string> RPW_Property_Grid_Tab_Win_Member_Family_edit = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Member Family"},
            {"CLASS_NAME",""}
        };

        //Mark Family  in Property grid

        public static Dictionary<string, string> RPW_Property_Grid_Tab_Win_Mark_Family = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Mark Family"},
            {"CLASS_NAME",""}
        };

        //Edit Mark Family  in Property grid

        public static Dictionary<string, string> RPW_Property_Grid_Tab_Win_Mark_Family_edit = new Dictionary<string, string>()
        {
            {"ID",""},
            {"NAME","Mark Family"},
            {"CLASS_NAME",""}
        };

        //Message window

        public static Dictionary<string, string> RPW_Message_Tab = new Dictionary<string, string>()
        {
            {"ID","TabItem Key Aveva.Core.Presentation.MessageWindow"},
            {"NAME","Messages"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> RPW_Message_Tab_System_Tab = new Dictionary<string, string>()
        {
            {"ID","TabItem Index : 1"},
            {"NAME","System"},
            {"CLASS_NAME",""}
        };

        //Attribute window

        public static Dictionary<string, string> RPW_Attribute_Tab = new Dictionary<string, string>()
        {
            {"ID","TabItem Key Aveva.AttributesUtility"},
            {"NAME","Attributes"},
            {"CLASS_NAME",""}
        };


        //Command window

        public static Dictionary<string, string> RPW_Command_Window_Tab = new Dictionary<string, string>()
        {
            {"ID","TabItem Key !!CADCBTH"},
            {"NAME","Command Window"},
            {"CLASS_NAME",""}
        };

        public static Dictionary<string, string> RPW_Command_Window_Tab_Win = new Dictionary<string, string>()
        {
            {"ID","commandTextBox"},
            {"NAME","label1"},
            {"CLASS_NAME","WindowsForms10.EDIT.app.0.1ca0192_r9_ad1"}
        };

        #endregion        

        #region Model Explorer

        //Model Explorer tab

        public static Dictionary<string, string> LPW_Model_Explorer_Tab = new Dictionary<string, string>()
        {
            {"ID","TabItem Key DesignExplorer"},
            {"NAME","Model Explorer"},
            {"CLASS_NAME",""}
        };

        //Model Explorer Window

        public static Dictionary<string, string> LPW_Model_Explorer_Tab_Win = new Dictionary<string, string>()
        {
            {"ID","DesignExplorer"},
            {"NAME",""},
            {"CLASS_NAME","WindowsForms10.Window.8.app.0.1ca0192_r9_ad1"}
        };

        //Grid World

        public static Dictionary<string, string> LPW_Model_Explorer_Tab_Win_Grd_world = new Dictionary<string, string>()
        {
            {"ID","[Node] 0, [Node] 0"},
            {"NAME","GRIDWL BOCAD_GRIDS "},
            {"CLASS_NAME",""}
        };

        //REFGRD

        public static Dictionary<string, string> LPW_Model_Explorer_Tab_Win_Grd_world_refgrd1 = new Dictionary<string, string>()
        {
            {"ID","[Node] 0, [Node] 0, [Node] 1"},
            {"NAME","REFGRD 2"},
            {"CLASS_NAME",""}
        };

        //REFGRD context menu

        public static Dictionary<string, string> LPW_Model_Explorer_Tab_Win_Grd_world_refgrd_contextmenu = new Dictionary<string, string>()
        {
            {"ID","[MenuAgent Items] Menu Item :  - Index : 0 "},
            {"NAME","3D View"},
            {"CLASS_NAME",""}
        };

        //REFGRD context menu remove

        public static Dictionary<string, string> LPW_Model_Explorer_Tab_Win_Grd_world_refgrd_contextmenu_remove = new Dictionary<string, string>()
        {
            {"ID","[3D &View Items] Menu Item :  - Index : 5"},
            {"NAME","Remove Only"},
            {"CLASS_NAME",""}
        };




        //DTworld

        public static Dictionary<string, string> LPW_Model_Explorer_Tab_Win_DTWorld = new Dictionary<string, string>()
        {
            {"ID","[Node] 0, [Node] 2"},
            {"NAME","DTWRLD DETWORLD_1"},
            {"CLASS_NAME",""}
        };


        #endregion

 
        #endregion

    }

}
