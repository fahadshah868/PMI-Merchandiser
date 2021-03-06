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
    ///The ChooseNonTKShop recording.
    /// </summary>
    [TestModule("e400e0b7-a770-410d-81a2-acb48b843cf0", ModuleType.Recording, 1)]
    public partial class ChooseNonTKShop : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TradeTrackerProject.TradeTrackerProjectRepository repository.
        /// </summary>
        public static TradeTrackerProject.TradeTrackerProjectRepository repo = TradeTrackerProject.TradeTrackerProjectRepository.Instance;

        static ChooseNonTKShop instance = new ChooseNonTKShop();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ChooseNonTKShop()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ChooseNonTKShop Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=59}) on item 'PkComTradetracker.ShopsList_validation'.", repo.PkComTradetracker.ShopsList_validationInfo, new RecordItemIndex(0));
            Validate.ContainsImage(repo.PkComTradetracker.ShopsList_validationInfo, ShopsList_validation_Screenshot1, ShopsList_validation_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(1));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            ConstantUserCode.UserCodeCollection.chooseNonTKShopFromList();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage ShopsList_validation_Screenshot1
        { get { return repo.PkComTradetracker.ShopsList_validationInfo.GetScreenshot1(new Rectangle(0, 0, 480, 59)); } }

        Imaging.FindOptions ShopsList_validation_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
