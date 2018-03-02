﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TradeTrackerProject.TestCases.TK_ShopOpen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VisitTPOSM2 recording.
    /// </summary>
    [TestModule("adf0aabf-b31e-45d6-9c4d-9bca783af0a2", ModuleType.Recording, 1)]
    public partial class VisitTPOSM2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TradeTrackerProject.TradeTrackerProjectRepository repository.
        /// </summary>
        public static TradeTrackerProject.TradeTrackerProjectRepository repo = TradeTrackerProject.TradeTrackerProjectRepository.Instance;

        static VisitTPOSM2 instance = new VisitTPOSM2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VisitTPOSM2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VisitTPOSM2 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.TPOSMHeader_Validation'.", repo.PkComTradetracker.TPOSMHeader_ValidationInfo, new RecordItemIndex(0));
            Validate.ContainsImage(repo.PkComTradetracker.TPOSMHeader_ValidationInfo, TPOSMHeader_Validation_Screenshot1, TPOSMHeader_Validation_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(1));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ValidateOKButton' at Center", repo.PkComTradetracker.ValidateOKButtonInfo, new RecordItemIndex(2));
            repo.PkComTradetracker.ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_Option1' at Center", repo.PkComTradetracker.ShopOpen_Option1Info, new RecordItemIndex(3));
            repo.PkComTradetracker.ShopOpen_Option1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '5' on item 'PkComTradetracker.ShopOpen_TPOSM_EnterQuantity'.", repo.PkComTradetracker.ShopOpen_TPOSM_EnterQuantityInfo, new RecordItemIndex(4));
            repo.PkComTradetracker.ShopOpen_TPOSM_EnterQuantity.Element.SetAttributeValue("Text", "5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_EnterQuantityOkButton' at Center", repo.PkComTradetracker.ShopOpen_EnterQuantityOkButtonInfo, new RecordItemIndex(5));
            repo.PkComTradetracker.ShopOpen_EnterQuantityOkButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_Option2' at Center", repo.PkComTradetracker.ShopOpen_Option2Info, new RecordItemIndex(6));
            repo.PkComTradetracker.ShopOpen_Option2.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionYesButton' at Center", repo.PkComTradetracker.ChangeOptionYesButtonInfo, new RecordItemIndex(7));
            repo.PkComTradetracker.ChangeOptionYesButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.List2.ShopOpen_Option3' at Center", repo.PkComTradetracker.List2.ShopOpen_Option3Info, new RecordItemIndex(8));
            repo.PkComTradetracker.List2.ShopOpen_Option3.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionYesButton' at Center", repo.PkComTradetracker.ChangeOptionYesButtonInfo, new RecordItemIndex(9));
            repo.PkComTradetracker.ChangeOptionYesButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.List2.ShopOpen_Option4' at Center", repo.PkComTradetracker.List2.ShopOpen_Option4Info, new RecordItemIndex(10));
            repo.PkComTradetracker.List2.ShopOpen_Option4.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionYesButton' at Center", repo.PkComTradetracker.ChangeOptionYesButtonInfo, new RecordItemIndex(11));
            repo.PkComTradetracker.ChangeOptionYesButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.List2.ShopOpen_Option5' at Center", repo.PkComTradetracker.List2.ShopOpen_Option5Info, new RecordItemIndex(12));
            repo.PkComTradetracker.List2.ShopOpen_Option5.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionYesButton' at Center", repo.PkComTradetracker.ChangeOptionYesButtonInfo, new RecordItemIndex(13));
            repo.PkComTradetracker.ChangeOptionYesButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(14));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.ShopOpen_TPOSM_validation'.", repo.PkComTradetracker.ShopOpen_TPOSM_validationInfo, new RecordItemIndex(15));
            Validate.ContainsImage(repo.PkComTradetracker.ShopOpen_TPOSM_validationInfo, ShopOpen_TPOSM_validation_Screenshot1, ShopOpen_TPOSM_validation_Screenshot1_Options);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage TPOSMHeader_Validation_Screenshot1
        { get { return repo.PkComTradetracker.TPOSMHeader_ValidationInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions TPOSMHeader_Validation_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ShopOpen_TPOSM_validation_Screenshot1
        { get { return repo.PkComTradetracker.ShopOpen_TPOSM_validationInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions ShopOpen_TPOSM_validation_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
