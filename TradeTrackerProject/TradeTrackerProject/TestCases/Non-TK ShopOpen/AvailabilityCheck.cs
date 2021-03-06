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

namespace TradeTrackerProject.TestCases.Non_TK_ShopOpen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AvailabilityCheck recording.
    /// </summary>
    [TestModule("3974fce3-ea62-408f-bfdb-fbdacb02943e", ModuleType.Recording, 1)]
    public partial class AvailabilityCheck : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TradeTrackerProject.TradeTrackerProjectRepository repository.
        /// </summary>
        public static TradeTrackerProject.TradeTrackerProjectRepository repo = TradeTrackerProject.TradeTrackerProjectRepository.Instance;

        static AvailabilityCheck instance = new AvailabilityCheck();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AvailabilityCheck()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AvailabilityCheck Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_AvailabilityCheck' at Center", repo.PkComTradetracker.ShopOpen_AvailabilityCheckInfo, new RecordItemIndex(0));
            repo.PkComTradetracker.ShopOpen_AvailabilityCheck.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.ShopOpen_AvailabilityCheck_validation'.", repo.PkComTradetracker.ShopOpen_AvailabilityCheck_validationInfo, new RecordItemIndex(1));
            Validate.ContainsImage(repo.PkComTradetracker.ShopOpen_AvailabilityCheck_validationInfo, ShopOpen_AvailabilityCheck_validation_Screenshot1, ShopOpen_AvailabilityCheck_validation_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            ConstantUserCode.UserCodeCollection.visitAvailabilityCheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(3));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Non-TK') on item 'PkComTradetracker.Validate_NonTKShopScreen'.", repo.PkComTradetracker.Validate_NonTKShopScreenInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.PkComTradetracker.Validate_NonTKShopScreenInfo, "Text", "Non-TK");
            Delay.Milliseconds(0);
            
            ConstantUserCode.UserCodeCollection.countNonTKShopModules();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(6));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionNoButton' at Center", repo.PkComTradetracker.ChangeOptionNoButtonInfo, new RecordItemIndex(7));
            repo.PkComTradetracker.ChangeOptionNoButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(8));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionYesButton' at Center", repo.PkComTradetracker.ChangeOptionYesButtonInfo, new RecordItemIndex(9));
            repo.PkComTradetracker.ChangeOptionYesButton.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
        CompressedImage ShopOpen_AvailabilityCheck_validation_Screenshot1
        { get { return repo.PkComTradetracker.ShopOpen_AvailabilityCheck_validationInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions ShopOpen_AvailabilityCheck_validation_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
