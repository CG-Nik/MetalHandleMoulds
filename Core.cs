using Alta;
using CustomRecipesAPI;
using MelonLoader;
using UnityEngine;
using System.Reflection;
using Alta.Inventory;

[assembly: MelonInfo(typeof(MetalHandleMoulds.Core), "MetalHandleMoulds", "1.0.0", "CGNik", null)]
[assembly: MelonGame("Alta", "A Township Tale")]

namespace MetalHandleMoulds
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
            CustomRecipesAPI.Core.SetUpRecipes += SetUpRecipes;
        }

        private void SetUpRecipes()
        {
            AssetBundle assetBundle;
            using (System.IO.Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MetalHandleMoulds.AssetBundles.!metalhandlemoulds"))
            {
                assetBundle = AssetBundle.LoadFromStream(stream);
            }

            MouldDefinition mouldDefinition_handleFist = assetBundle.LoadAsset<MouldDefinition>("Handle Fist Mould.asset");
            MouldDefinition mouldDefinition_handleLargeCool = assetBundle.LoadAsset<MouldDefinition>("Handle Large Cool Mould.asset");
            MouldDefinition mouldDefinition_handleMediumCool = assetBundle.LoadAsset<MouldDefinition>("Handle Medium Cool Mould.asset");
            MouldDefinition mouldDefinition_handleMediumCurved = assetBundle.LoadAsset<MouldDefinition>("Handle Medium Curved Mould.asset");
            MouldDefinition mouldDefinition_handleShortCCurve = assetBundle.LoadAsset<MouldDefinition>("Handle Short C Curve Mould.asset");
            MouldDefinition mouldDefinition_handleShortCool = assetBundle.LoadAsset<MouldDefinition>("Handle Short Cool Mould.asset");
            MouldDefinition mouldDefinition_handleShortPointyEnd = assetBundle.LoadAsset<MouldDefinition>("Handle Short Pointy End Mould.asset");

            CustomRecipesAPI.Core.SetUpMould(Item.All.Where(item => item.Hash == 46034u).First(), mouldDefinition_handleFist, true, false, true, null, null);
            CustomRecipesAPI.Core.SetUpMould(Item.All.Where(item => item.Hash == 40154u).First(), mouldDefinition_handleLargeCool, true, true, false, new Vector3(0f, -0.4f, -1.1f), null);
            CustomRecipesAPI.Core.SetUpMould(Item.All.Where(item => item.Hash == 25450u).First(), mouldDefinition_handleMediumCool, true, true, false, new Vector3(0f, -0.2f, -0.7f), null);
            CustomRecipesAPI.Core.SetUpMould(Item.All.Where(item => item.Hash == 22576u).First(), mouldDefinition_handleMediumCurved, true, true, false, new Vector3(0f, 0f, -0.1f), null);
            CustomRecipesAPI.Core.SetUpMould(Item.All.Where(item => item.Hash == 36240u).First(), mouldDefinition_handleShortCCurve, true, true, false, null, null);
            CustomRecipesAPI.Core.SetUpMould(Item.All.Where(item => item.Hash == 61562u).First(), mouldDefinition_handleShortCool, true, true, false, null, null);
            CustomRecipesAPI.Core.SetUpMould(Item.All.Where(item => item.Hash == 19208u).First(), mouldDefinition_handleShortPointyEnd, true, true, false, null, null);
        }
    }
}