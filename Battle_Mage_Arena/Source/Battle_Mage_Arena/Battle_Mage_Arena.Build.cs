// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Battle_Mage_Arena : ModuleRules
{
	public Battle_Mage_Arena(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Battle_Mage_Arena",
			"Battle_Mage_Arena/Variant_Platforming",
			"Battle_Mage_Arena/Variant_Platforming/Animation",
			"Battle_Mage_Arena/Variant_Combat",
			"Battle_Mage_Arena/Variant_Combat/AI",
			"Battle_Mage_Arena/Variant_Combat/Animation",
			"Battle_Mage_Arena/Variant_Combat/Gameplay",
			"Battle_Mage_Arena/Variant_Combat/Interfaces",
			"Battle_Mage_Arena/Variant_Combat/UI",
			"Battle_Mage_Arena/Variant_SideScrolling",
			"Battle_Mage_Arena/Variant_SideScrolling/AI",
			"Battle_Mage_Arena/Variant_SideScrolling/Gameplay",
			"Battle_Mage_Arena/Variant_SideScrolling/Interfaces",
			"Battle_Mage_Arena/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
