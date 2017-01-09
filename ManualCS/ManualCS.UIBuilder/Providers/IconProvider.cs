using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualCS.UIBuilder.Providers
{
    public class IconProvider
    {
        private ImageList iconList = null;

        public ImageList IconList
        {
            get
            {
                if (iconList == null)
                    iconList = BuildIconList();

                return iconList;
            }
        }

        private ImageList BuildIconList()
        {
            ImageList iconList = new ImageList();

            iconList.ImageSize = new Size(32, 32);
            
            iconList.Images.Add(IconResource.ActiveServerPage_asp__11272_32x);
            iconList.Images.Add(IconResource.BDCModelTemplate_32x);

            
            iconList.Images.Add(IconResource.ActiveServerPage_asp__11272_32x);
            iconList.Images.Add(IconResource.BDCModelTemplate_32x);
            iconList.Images.Add(IconResource.BrokenlinktoFile_431_32x);
            iconList.Images.Add(IconResource.CABProject_5818_32x);
            iconList.Images.Add(IconResource.ClassIcon_32x);
            iconList.Images.Add(IconResource.CompiledMSHelpFile_11556_32x);
            iconList.Images.Add(IconResource.ComponentDiagramFile_componentdiagram_13449_32x);
            iconList.Images.Add(IconResource.CPPWMIEventProvider_7864_32x);
            iconList.Images.Add(IconResource.CSEmptyCodeFile_753_32x);
            iconList.Images.Add(IconResource.CustomActions_6334_32x);
            iconList.Images.Add(IconResource.DatabaseProject_7342_32x);
            iconList.Images.Add(IconResource.DBSchema_12823_32x);
            iconList.Images.Add(IconResource.DeploymentDiagram_SubsystemMapper__11298_32x);
            iconList.Images.Add(IconResource.DialogGroup_5846_32x);
            iconList.Images.Add(IconResource.DialogID_6220_32x);
            iconList.Images.Add(IconResource.FieldsHeader_32x);
            iconList.Images.Add(IconResource.Folder_special__5843_32x);
            iconList.Images.Add(IconResource.GenericVSProject_9906_32x);
            iconList.Images.Add(IconResource.GlobalApplicationClass_asax__443_32x);
            iconList.Images.Add(IconResource.HTMLPage_HTM__825_32x);
            iconList.Images.Add(IconResource.Index_8287_32x);
            iconList.Images.Add(IconResource.LinkedServer_12789_32x);
            iconList.Images.Add(IconResource.Login_6031_32x);
            iconList.Images.Add(IconResource.LoginScreen_7349_32x);
            iconList.Images.Add(IconResource.MainMenuControl_688_32x);
            iconList.Images.Add(IconResource.MapTileLayer_32x);
            iconList.Images.Add(IconResource.MasterPage_6478_32x);
            iconList.Images.Add(IconResource.MergeModuleReference_6335_32x);
            iconList.Images.Add(IconResource.ModelingProject_13455_32x);
            iconList.Images.Add(IconResource.MSHelpCollectionDefinitionFile_11560_32x);
            iconList.Images.Add(IconResource.PolicyWarnings_large__7879);
            iconList.Images.Add(IconResource.Procedure_8937_32x);
            iconList.Images.Add(IconResource.project_control_on_32x32);
            iconList.Images.Add(IconResource.RegistryEditor_5838_32x);
            iconList.Images.Add(IconResource.Reports_collapsed_12995_32x);
            iconList.Images.Add(IconResource.SequenceDiagramFile_sequencediagram_13452_32x);
            iconList.Images.Add(IconResource.Setup_6331_32x);
            iconList.Images.Add(IconResource.SetupProjectWizard_5827_32x);
            iconList.Images.Add(IconResource.setup_v_32x);
            iconList.Images.Add(IconResource.Shortcut_8169_32x);
            iconList.Images.Add(IconResource.SingleOutput_8170_32x);
            iconList.Images.Add(IconResource.SoftwareDefinitionModel_11321_32x);
            iconList.Images.Add(IconResource.StyleSheet_css__7483_32x);
            iconList.Images.Add(IconResource.Textfile_818_32x);
            iconList.Images.Add(IconResource.TFSServer_13310_32x);
            iconList.Images.Add(IconResource.ToolBarControl_710_32x);
            iconList.Images.Add(IconResource.UMLModelFile_13454_32x);
            iconList.Images.Add(IconResource.UseCaseDiagramFile_usecasediagram_13447_32x);
            iconList.Images.Add(IconResource.UserDefinedDataType_8271_32x);
            iconList.Images.Add(IconResource.UserInterfaceEditor_5845_32x);
            iconList.Images.Add(IconResource.VBEmptyCodefile_793_32x);
            iconList.Images.Add(IconResource.View_8933_32x);
            iconList.Images.Add(IconResource.VSNETWebServiceDynamicDiscovery_8215_32x);
            iconList.Images.Add(IconResource.WCFDataServices_32x);
            iconList.Images.Add(IconResource.WebCustomControl_ASCX__816_32x);
            iconList.Images.Add(IconResource.WebForm_ASPX__815_32x_color);
            iconList.Images.Add(IconResource.WebUserControl_ascx__11270_32x);
            iconList.Images.Add(IconResource.WindowsForm_817_32x);
            iconList.Images.Add(IconResource.XMLFile_828_32x);
            iconList.Images.Add(IconResource.XMLSchema_798_32x);
            iconList.Images.Add(IconResource.XSXDSchema_ElementIcon_32x32);

            return iconList;
        }
    }
}
