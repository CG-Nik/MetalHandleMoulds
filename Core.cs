using Alta;
using CustomRecipesAPI;
using MelonLoader;
using UnityEngine;
using System.Reflection;

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
            MouldItemComponent mouldItemComponent_handleFist = assetBundle.LoadAsset<MouldItemComponent>("Handle Fist MIC.asset");
            MouldDefinition mouldDefinition_handleLargeCool = assetBundle.LoadAsset<MouldDefinition>("Handle Large Cool Mould.asset");
            MouldItemComponent mouldItemComponent_handleLargeCool = assetBundle.LoadAsset<MouldItemComponent>("Handle Large Cool MIC.asset");
            MouldDefinition mouldDefinition_handleMediumCool = assetBundle.LoadAsset<MouldDefinition>("Handle Medium Cool Mould.asset");
            MouldItemComponent mouldItemComponent_handleMediumCool = assetBundle.LoadAsset<MouldItemComponent>("Handle Medium Cool MIC.asset");
            MouldDefinition mouldDefinition_handleMediumCurved = assetBundle.LoadAsset<MouldDefinition>("Handle Medium Curved Mould.asset");
            MouldItemComponent mouldItemComponent_handleMediumCurved = assetBundle.LoadAsset<MouldItemComponent>("Handle Medium Curved MIC.asset");
            MouldDefinition mouldDefinition_handleShortCCurve = assetBundle.LoadAsset<MouldDefinition>("Handle Short C Curve Mould.asset");
            MouldItemComponent mouldItemComponent_handleShortCCurve = assetBundle.LoadAsset<MouldItemComponent>("Handle Short C Curve MIC.asset");
            MouldDefinition mouldDefinition_handleShortCool = assetBundle.LoadAsset<MouldDefinition>("Handle Short Cool Mould.asset");
            MouldItemComponent mouldItemComponent_handleShortCool = assetBundle.LoadAsset<MouldItemComponent>("Handle Short Cool MIC.asset");
            MouldDefinition mouldDefinition_handleShortPointyEnd = assetBundle.LoadAsset<MouldDefinition>("Handle Short Pointy End Mould.asset");
            MouldItemComponent mouldItemComponent_handleShortPointyEnd = assetBundle.LoadAsset<MouldItemComponent>("Handle Short Pointy End MIC.asset");

            CustomRecipesAPI.Core.SetUpMould(46034u, mouldDefinition_handleFist, mouldItemComponent_handleFist, false, true, null, null);
            CustomRecipesAPI.Core.SetUpMould(40154u, mouldDefinition_handleLargeCool, mouldItemComponent_handleLargeCool, true, false, new Vector3(0f, -0.4f, -1.1f), null);
            CustomRecipesAPI.Core.SetUpMould(25450u, mouldDefinition_handleMediumCool, mouldItemComponent_handleMediumCool, true, false, new Vector3(0f, -0.2f, -0.7f), null);
            CustomRecipesAPI.Core.SetUpMould(22576u, mouldDefinition_handleMediumCurved, mouldItemComponent_handleMediumCurved, true, false, new Vector3(0f, 0f, -0.1f), null);
            CustomRecipesAPI.Core.SetUpMould(36240u, mouldDefinition_handleShortCCurve, mouldItemComponent_handleShortCCurve, true, false, null, null);
            CustomRecipesAPI.Core.SetUpMould(61562u, mouldDefinition_handleShortCool, mouldItemComponent_handleShortCool, true, false, null, null);
            CustomRecipesAPI.Core.SetUpMould(19208u, mouldDefinition_handleShortPointyEnd, mouldItemComponent_handleShortPointyEnd, true, false, null, null);
        }
    }
}