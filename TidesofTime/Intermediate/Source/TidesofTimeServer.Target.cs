using UnrealBuildTool;

public class TidesofTimeServerTarget : TargetRules
{
	public TidesofTimeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("TidesofTime");
	}
}
