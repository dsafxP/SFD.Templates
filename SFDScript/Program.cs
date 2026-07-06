using SFDGameScriptInterface;

namespace MySFDScript;

public abstract class GameScriptInterfaceExtended : GameScriptInterface
{
    protected IGame Game;
}

public partial class GameScript : GameScriptInterfaceExtended
{
    // ...
}
