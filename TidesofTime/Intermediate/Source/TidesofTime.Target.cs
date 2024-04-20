using UnrealBuildTool;

public class TidesofTimeTarget : TargetRules
{
	public TidesofTimeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TidesofTime");
	}
}
