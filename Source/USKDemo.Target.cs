// Created by Henry Jooste

using UnrealBuildTool;
using System.Collections.Generic;

public class USKDemoTarget : TargetRules
{
	public USKDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "USKDemo" } );
	}
}
