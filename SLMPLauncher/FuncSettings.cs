﻿using System.Collections.Generic;
using System.IO;

namespace SLMPLauncher
{
    public class FuncSettings
    {
        public static void setSettingsPreset(int value)
        {
            if (value == 0)
            {
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMultiSample", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "8");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iTexMipMapSkip", "2");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fLightLODStartFade", "200.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultActors", "3.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultObjects", "3.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultItems", "2.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iShadowMapResolution", "512");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFXAAEnabled", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Grass", "fGrassStartFadeDistance", "1000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Grass", "iMinGrassSize", "50");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel1FadeDist", "4096.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel2FadeDist", "3072.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fShadowDistance", "2000.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fTreeLoadDistance", "12500.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockMaximumDistance", "75000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel1Distance", "25000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel0Distance", "15000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fSplitDistanceMult", "0.4000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fTreesMidLODSwitchDist", "3500.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "MAIN", "fSkyCellRefFadeDistance", "50000.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODLand", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODObjects", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODTrees", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectSky", "1");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Water", "iWaterReflectWidth", "512");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Water", "iWaterReflectHeight", "512");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bDecals", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecalPerActor", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecals", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Display", "fDecalLifetime", "0.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxSkinDecalsPerFrame", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxDecalsPerFrame", "0");
            }
            else if (value == 1)
            {
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMultiSample", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "16");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iTexMipMapSkip", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fLightLODStartFade", "1000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultActors", "5.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultObjects", "6.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultItems", "5.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iShadowMapResolution", "1024");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFXAAEnabled", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Grass", "fGrassStartFadeDistance", "3000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Grass", "iMinGrassSize", "35");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel1FadeDist", "4096.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel2FadeDist", "3072.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fShadowDistance", "2500.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fTreeLoadDistance", "25000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockMaximumDistance", "100000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel1Distance", "32768.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel0Distance", "20480.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fSplitDistanceMult", "0.7500");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fTreesMidLODSwitchDist", "4000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "MAIN", "fSkyCellRefFadeDistance", "150000.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODLand", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODObjects", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODTrees", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectSky", "1");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Water", "iWaterReflectWidth", "512");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Water", "iWaterReflectHeight", "512");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bDecals", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecalPerActor", "3");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecals", "30");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Display", "fDecalLifetime", "30.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxSkinDecalsPerFrame", "35");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxDecalsPerFrame", "350");
            }
            else if (value == 2)
            {
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMultiSample", "2");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "16");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iTexMipMapSkip", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fLightLODStartFade", "2500.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultActors", "9.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultObjects", "10.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultItems", "7.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iShadowMapResolution", "2048");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFXAAEnabled", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Grass", "fGrassStartFadeDistance", "5000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Grass", "iMinGrassSize", "20");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel1FadeDist", "16896.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel2FadeDist", "16896.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fShadowDistance", "4000.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fTreeLoadDistance", "40000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockMaximumDistance", "150000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel1Distance", "40000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel0Distance", "25000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fSplitDistanceMult", "1.1000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fTreesMidLODSwitchDist", "5000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "MAIN", "fSkyCellRefFadeDistance", "300000.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODLand", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODObjects", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODTrees", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectSky", "1");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Water", "iWaterReflectWidth", "1024");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Water", "iWaterReflectHeight", "1024");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bDecals", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecalPerActor", "5");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecals", "50");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Display", "fDecalLifetime", "60.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxSkinDecalsPerFrame", "55");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxDecalsPerFrame", "350");
            }
            else if (value == 3)
            {
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMultiSample", "4");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "16");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iTexMipMapSkip", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fLightLODStartFade", "3500.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultActors", "15.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultObjects", "15.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultItems", "15.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iShadowMapResolution", "4096");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFXAAEnabled", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Grass", "fGrassStartFadeDistance", "7000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Grass", "iMinGrassSize", "15");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel1FadeDist", "16896.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel2FadeDist", "16896.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fShadowDistance", "8000.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fTreeLoadDistance", "75000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockMaximumDistance", "250000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel1Distance", "70000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel0Distance", "35000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fSplitDistanceMult", "1.5000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fTreesMidLODSwitchDist", "16896.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "MAIN", "fSkyCellRefFadeDistance", "600000.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODLand", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODObjects", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODTrees", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectSky", "1");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Water", "iWaterReflectWidth", "2048");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Water", "iWaterReflectHeight", "2048");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bDecals", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecalPerActor", "7");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecals", "70");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Display", "fDecalLifetime", "90.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxSkinDecalsPerFrame", "75");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxDecalsPerFrame", "350");
            }
            FuncParser.iniWrite(FormMain.pathSkyrimINI, "Display", "fNearDistance", "15.0000");
            FuncParser.iniWrite(FormMain.pathLauncherINI, "Game", "ZFighting", "0");
            FormMain.settingsPreset = value;
            checkENB();
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static void physicsFPS()
        {
            FuncParser.iniWrite(FormMain.pathSkyrimINI, "HAVOK", "fMaxTime", (((double)1 / FormMain.predictFPS).ToString() + "000000").Replace(",", ".").Remove(6));
            if (File.Exists(FormENB.pathENBLocalINI))
            {
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "LIMITER", "FPSLimit", FormMain.predictFPS.ToString() + ".0");
            }
        }
        public static void restoreENBAdapter()
        {
            if (File.Exists(FormENB.pathENBLocalINI))
            {
                int value = FuncParser.intRead(FormMain.pathSkyrimINI, "Display", "iAdapter");
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "MULTIHEAD", "VideoAdapterIndex", value.ToString());
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "MULTIHEAD", "ForceVideoAdapterIndex", (value > 0).ToString().ToLower());
            }
        }
        public static void restoreENBBorderless()
        {
            if (File.Exists(FormENB.pathENBLocalINI))
            {
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "WINDOW", "ForceBorderless", (FuncParser.stringRead(FormMain.pathSkyrimPrefsINI, "Display", "bFull Screen") == "0").ToString().ToLower());
            }
        }
        public static void restoreENBVSync()
        {
            if (File.Exists(FormENB.pathENBLocalINI))
            {
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "ENGINE", "EnableVSync", (FuncParser.stringRead(FormMain.pathSkyrimINI, "Display", "iPresentInterval") == "1").ToString().ToLower());
            }
        }
        public static void restoreENBVideoMemory()
        {
            if (File.Exists(FormENB.pathENBLocalINI))
            {
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "MEMORY", "VideoMemorySizeMb", FuncParser.stringRead(FormMain.pathLauncherINI, "ENB", "MemorySizeMb"));
            }
        }
        public static bool checkENBoost()
        {
            return FuncParser.readAsBool(FormENB.pathENBLocalINI, "GLOBAL", "UsePatchSpeedhackWithoutGraphics");
        }
        public static bool checkENB()
        {
            if (File.Exists(FormMain.pathGameFolder + @"d3d9.dll") && File.Exists(FormMain.pathGameFolder + "enblocal.ini"))
            {
                if (!checkENBoost())
                {
                    FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "0");
                    FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMultiSample", "0");
                    FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFXAAEnabled", "0");
                    FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFloatPointRenderTarget", "1");
                }
                else
                {
                    FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "0");
                    FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFloatPointRenderTarget", "0");
                }
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Display", "bAllowScreenshot", "0");
                return true;
            }
            else
            {
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFloatPointRenderTarget", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Display", "bAllowScreenshot", "1");
                return false;
            }
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static List<string> skyrimINI()
        {
            return new List<string> {
                "[General]",
                "sLanguage=RUSSIAN",
                "uGridsToLoad=5",
                "uExterior Cell Buffer=36",
                "uInterior Cell Buffer=4",
                "uMainMenuMusicAttnmB=300",
                "uMainMenuMusicFadeTimeMS=0",
                "fFlickeringLightDistance=4096.0000",
                "SIntroSequence=",
                "",
                "[Display]",
                "fLightLODMaxStartFade=3500.0000",
                "fDecalLifetime=90.0000",
                "fNearDistance=15.0000",
                "fLightLODRange=50000.0000",
                "iPresentInterval=1",
                "bAllowScreenshot=1",
                "iAdapter=0",
                "",
                "[Audio]",
                "fMusicDuckingSeconds=6.0000",
                "fMusicUnDuckingSeconds=8.0000",
                "fMenuModeFadeOutTime=3.0000",
                "fMenuModeFadeInTime=1.0000",
                "uMaxSizeForCachedSound=4096",
                "",
                "[Actor]",
                "fVisibleNavmeshMoveDist=12288.0000",
                "",
                "[Grass]",
                "bAllowCreateGrass=1",
                "bAllowLoadGrass=0",
                "bDrawShaderGrass=1",
                "iMaxGrassTypesPerTexure=15",
                "iMinGrassSize=15",
                "",
                "[Camera]",
                "fOverShoulderHorseAddY=-72.0000",
                "fOverShoulderHorsePosZ=50.0000",
                "fOverShoulderHorsePosX=35.0000",
                "fActorFadeOutLimit=-100.0000",
                "fAutoVanityModeDelay=36000.0000",
                "",
                "[GeneralWarnings]",
                "SGeneralMasterMismatchWarning=Check the \"Warnings.txt\" file for more information.",
                "",
                "[Archive]",
                "sResourceArchiveList=GameComm.bsa, GameText1.bsa, GameText2.bsa, GameText3.bsa, GameText4.bsa, GameText5.bsa, GameText6.bsa, GameText7.bsa, GameText8.bsa, GameText9.bsa, GameMesh1.bsa, GameMesh2.bsa, GameMesh3.bsa, GameVoice1.bsa, GameVoice2.bsa",
                "sResourceArchiveList2=",
                "",
                "[Combat]",
                "f1PArrowTiltUpAngle=0.7000",
                "f3PArrowTiltUpAngle=1.4000",
                "f1PBoltTiltUpAngle=1.0000",
                "f3PBoltTiltUpAngle=1.1000",
                "fMagnetismStrafeHeadingMult=0.0000",
                "fMagnetismLookingMult=0.0000",
                "",
                "[Papyrus]",
                "fPostLoadUpdateTimeMS=500.0000",
                "bEnableLogging=0",
                "bEnableTrace=0",
                "",
                "[HAVOK]",
                "fMaxTime=0.0166",
                "",
                "[SaveGame]",
                "iAutoSaveCount=6",
                "",
                "[Interface]",
                "bShowTutorials=0",
                "",
                "[Imagespace]",
                "iRadialBlurLevel=0",
                "",
                "[Decals]",
                "bDecals=1",
                "uMaxSkinDecals=70",
                "uMaxSkinDecalPerActor=7",
                "",
                "[MapMenu]",
                "fMapMoveKeyboardSpeed=0.0300",
                "fMapLookMouseSpeed=4.0000",
                "fMapLookGamepadSpeed=4.0000",
                "fMapZoomMouseSpeed=4.0000",
                "fMapWorldZoomSpeed=4.0000",
                "bWorldMapNoSkyDepthBlur=1",
                "fWorldMapDepthBlurScale=0.0000",
                "fWorldMapMaximumDepthBlur=0.0000",
                "fWorldMapNearDepthBlurScale=0.0000",
                "fMapWorldMaxPitch=90.0000",
                "fMapWorldMinPitch=0.0000",
                "fMapWorldYawRange=400.0000",
                "uLockedObjectMapLOD=16",
                "",
                "[Water]",
                "bReflectLODObjects=1",
                "bReflectLODLand=1",
                "bReflectSky=1",
                "bReflectLODTrees=1"};
        }
        public static List<string> skyrimPrefsINI()
        {
            return new List<string> {
                "[General]",
                "iStoryManagerLoggingEvent=0",
                "bEnableStoryManagerLogging=0",
                "",
                "[Imagespace]",
                "bDoDepthOfField=1",
                "",
                "[Display]",
                "iBlurDeferredShadowMask=5",
                "fInteriorShadowDistance=3000.0000",
                "fShadowDistance=8000.0000",
                "iMaxAnisotropy=16",
                "fTreesMidLODSwitchDist=16896.0000",
                "fGamma=1.0000",
                "fLightLODStartFade=3500.0000",
                "iTexMipMapMinimum=0",
                "iTexMipMapSkip=0",
                "iMultiSample=4",
                "bTreesReceiveShadows=1",
                "bDrawLandShadows=1",
                "bShadowsOnGrass=1",
                "bFull Screen=0",
                "iSize H=1280",
                "iSize W=720",
                "fMeshLODFadePercentDefault=1.2000",
                "fMeshLODFadeBoundDefault=256.0000",
                "fMeshLODLevel2FadeTreeDistance=2048.0000",
                "fMeshLODLevel1FadeTreeDistance=2844.0000",
                "fMeshLODLevel2FadeDist=16896.0000",
                "fMeshLODLevel1FadeDist=16896.0000",
                "iScreenShotIndex=0",
                "bShadowMaskZPrepass=0",
                "bMainZPrepass=0",
                "iMaxSkinDecalsPerFrame=75",
                "iMaxDecalsPerFrame=350",
                "iShadowFilter=3",
                "bDeferredShadows=1",
                "bTransparencyMultisampling=0",
                "bFloatPointRenderTarget=0",
                "bFXAAEnabled=1",
                "iShadowMapResolution=4096",
                "fShadowBiasScale=1.0000",
                "iShadowMaskQuarter=4",
                "",
                "[Grass]",
                "fGrassStartFadeDistance=7000.0000",
                "fGrassMaxStartFadeDistance=7000.0000",
                "fGrassMinStartFadeDistance=400.0000",
                "",
                "[MAIN]",
                "bGamepadEnable=0",
                "bCrosshairEnabled=1",
                "fHUDOpacity=1.0000",
                "bSaveOnPause=0",
                "bSaveOnTravel=1",
                "bSaveOnWait=0",
                "bSaveOnRest=0",
                "fSkyCellRefFadeDistance=600000.0000",
                "",
                "[GamePlay]",
                "bShowFloatingQuestMarkers=1",
                "bShowQuestMarkers=1",
                "iDifficulty=2",
                "",
                "[Interface]",
                "bDialogueSubtitles=0",
                "bGeneralSubtitles=0",
                "fMouseCursorSpeed=1.0000",
                "bShowCompass=1",
                "",
                "[Controls]",
                "fGamepadHeadingSensitivity=1.0000",
                "fMouseHeadingSensitivity=0.0250",
                "bAlwaysRunByDefault=1",
                "bInvertYValues=0",
                "bGamePadRumble=0",
                "bUseKinect=0",
                "",
                "[Particles]",
                "iMaxDesired=750",
                "",
                "[SaveGame]",
                "fAutosaveEveryXMins=60.0000",
                "",
                "[AudioMenu]",
                "fAudioMasterVolume=1.0000",
                "fVal7=1.0000",
                "uID7=0",
                "fVal6=1.0000",
                "uID6=0",
                "fVal5=1.0000",
                "uID5=0",
                "fVal4=1.0000",
                "uID4=0",
                "fVal3=1.0000",
                "uID3=0",
                "fVal2=0.7500",
                "uID2=466532",
                "fVal1=0.7500",
                "uID1=554685",
                "fVal0=1.0000",
                "uID0=1007612",
                "",
                "[TerrainManager]",
                "fTreeLoadDistance=75000.0000",
                "fBlockMaximumDistance=250000.0000",
                "fBlockLevel1Distance=70000.0000",
                "fBlockLevel0Distance=35000.0000",
                "fSplitDistanceMult=1.5000",
                "",
                "[Trees]",
                "bRenderSkinnedTrees=1",
                "uiMaxSkinnedTreesToRender=20",
                "",
                "[LOD]",
                "fLODFadeOutMultObjects=15.0000",
                "fLODFadeOutMultItems=15.0000",
                "fLODFadeOutMultActors=15.0000",
                "fLODFadeOutMultSkyCell=1.0000",
                "",
                "[Water]",
                "iWaterReflectHeight=2048",
                "iWaterReflectWidth=2048",
                "bUseWaterDisplacements=1",
                "bUseWaterReflections=1"};
        }
        public static List<string> pluginsTXT()
        {
            return new List<string> {
                "Update.esm",
                "Dawnguard.esm",
                "HearthFires.esm",
                "Dragonborn.esm",
                "Unofficial Skyrim Legendary Edition Patch.esp",
                "Wyrmstooth.esp",
                "Falskaar.esp",
                "EnhancedLightsFX.esp",
                "Cutting Room Floor.esp",
                "Landscape Improved.esp",
                "Interiors Furniture Fix.esp",
                "AudioOverhaulSkyrim.esp",
                "Book Covers Skyrim.esp",
                "CCFWAF.esp",
                "Campfire.esm",
                "OSA.esm",
                "FNIS.esp",
                "getSnowy.esp",
                "CoinPurse.esp",
                "AlternateStart.esp",
                "FollowerOutfits.esp",
                "FloraRespawnFix.esp",
                "Blacksmith Chests.esp",
                "ConstantLushTrees.esp",
                "ConstantRareTrees.esp",
                "DeadlySpellImpacts.esp",
                "DestructibleBottles.esp",
                "Quests Markers.esp",
                "ArmorWeapon.esp",
                "HorseArmor.esp",
                "ENB Vision.esp",
                "RaceMenu.esp",
                "RMOverlays.esp",
                "EyesHairs.esp",
                "SkyUI.esp",
                "iHUD.esp",
                "iNeed.esp",
                "Frostfall.esp",
                "Ordinator.esp",
                "Footprints.esp",
                "iNeed - DD.esp",
                "BFSEffects.esp",
                "Frostfall-WS.esp",
                "TradeBarter.esp",
                "Headtracking.esp",
                "UIExtensions.esp",
                "AHZmoreHUD.esp",
                "HelmetToggle.esp",
                "InvisEyeFixes.esp",
                "CameraScripter.esp",
                "AMatterOfTime.esp",
                "AddItemMenu2.esp",
                "Leveled Enemy.esp",
                "Enhanced Blood.esp",
                "Wearable Lantern.esp",
                "DisableFastTravel.esp",
                "Immersive Citizens.esp",
                "Dual Sheath Redux.esp",
                "Dual Wield Parrying.esp",
                "AcquisitiveSoulGem.esp",
                "JaxonzMapMarkers.esp",
                "WondersofWeather.esp",
                "AlwaysPickUpBooks.esp",
                "Customizable Camera.esp",
                "Follower Commentary.esp",
                "StaticLoadingScreens.esp",
                "Dual Sheath Redux Patch.esp"};
        }
    }
}