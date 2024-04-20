using UnrealBuildTool;

public class TidesofTimeClientTarget : TargetRules
{
	public TidesofTimeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("TidesofTime");
	}
}
