using UnrealBuildTool;

public class TidesofTimeEditorTarget : TargetRules
{
	public TidesofTimeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TidesofTime");
	}
}
