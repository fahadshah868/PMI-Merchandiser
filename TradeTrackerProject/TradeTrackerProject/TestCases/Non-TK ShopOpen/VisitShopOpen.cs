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
    ///The VisitShopOpen recording.
    /// </summary>
    [TestModule("f1c76b04-c567-4703-8e99-f4b32ad57684", ModuleType.Recording, 1)]
    public partial class VisitShopOpen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TradeTrackerProject.TradeTrackerProjectRepository repository.
        /// </summary>
        public static TradeTrackerProject.TradeTrackerProjectRepository repo = TradeTrackerProject.TradeTrackerProjectRepository.Instance;

        static VisitShopOpen instance = new VisitShopOpen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VisitShopOpen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VisitShopOpen Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=105}) on item 'PkComTradetracker.Shop_Info'.", repo.PkComTradetracker.Shop_InfoInfo, new RecordItemIndex(0));
            Validate.ContainsImage(repo.PkComTradetracker.Shop_InfoInfo, Shop_Info_Screenshot1, Shop_Info_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopDetails' at Center", repo.PkComTradetracker.ShopDetailsInfo, new RecordItemIndex(1));
            repo.PkComTradetracker.ShopDetails.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Info') on item 'PkComTradetracker.ShopDetails_Info'.", repo.PkComTradetracker.ShopDetails_InfoInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.PkComTradetracker.ShopDetails_InfoInfo, "Text", "Info");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopDetail_ProceedButton' at Center", repo.PkComTradetracker.ShopDetail_ProceedButtonInfo, new RecordItemIndex(3));
            repo.PkComTradetracker.ShopDetail_ProceedButton.Touch();
            Delay.Milliseconds(500);
            
            ConstantUserCode.UserCodeCollection.validateTradeTracker();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_AndroidWidgetImageView_MapCheckIn' at Center", repo.PkComTradetracker.ShopOpen_AndroidWidgetImageView_MapCheckInInfo, new RecordItemIndex(5));
            repo.PkComTradetracker.ShopOpen_AndroidWidgetImageView_MapCheckIn.Touch();
            Delay.Milliseconds(500);
            
            ConstantUserCode.UserCodeCollection.CheckIn_ListView();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'PkComTradetracker.ShopOptions_ListView'.", repo.PkComTradetracker.ShopOptions_ListViewInfo, new RecordItemIndex(7));
            Validate.Exists(repo.PkComTradetracker.ShopOptions_ListViewInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen' at Center", repo.PkComTradetracker.ShopOpenInfo, new RecordItemIndex(8));
            repo.PkComTradetracker.ShopOpen.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'PkComTradetracker.Validate_CameraScreen'.", repo.PkComTradetracker.Validate_CameraScreenInfo, new RecordItemIndex(9));
            Validate.Exists(repo.PkComTradetracker.Validate_CameraScreenInfo);
            Delay.Milliseconds(0);
            
            ConstantUserCode.UserCodeCollection.TakePhoto();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.TPOSM_ButtonDone' at Center", repo.PkComTradetracker.TPOSM_ButtonDoneInfo, new RecordItemIndex(11));
            repo.PkComTradetracker.TPOSM_ButtonDone.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Non-TK') on item 'PkComTradetracker.Validate_NonTKShopScreen'.", repo.PkComTradetracker.Validate_NonTKShopScreenInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.PkComTradetracker.Validate_NonTKShopScreenInfo, "Text", "Non-TK");
            Delay.Milliseconds(0);
            
            ConstantUserCode.UserCodeCollection.loadNonTKTPOSM();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage Shop_Info_Screenshot1
        { get { return repo.PkComTradetracker.Shop_InfoInfo.GetScreenshot1(new Rectangle(0, 0, 480, 105)); } }

        Imaging.FindOptions Shop_Info_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
