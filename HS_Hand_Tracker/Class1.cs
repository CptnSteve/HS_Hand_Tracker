using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker.Hearthstone.Entities;
using Hearthstone_Deck_Tracker.Enums.Hearthstone;
using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.LogReader;
using Hearthstone_Deck_Tracker.Plugins;


namespace Hand_Tracker
{
  public class Class1
  {

    internal static void TurnStart()
    {
    }

    internal static void GameStart(){
    }
  }
  public class Class1Plugin : IPlugin
  {
    public void OnLoad()
    {
      // Triggered upon startup and when the user ticks the plugin on
      GameEvents.OnGameStart.Add(Class1.GameStart);
    }

    public void OnUnload()
    {
        // Triggered when the user unticks the plugin, however, HDT does not completely unload the plugin.
        // see https://git.io/vxEcH
    }

    public void OnButtonPress()
    {
        // Triggered when the user clicks your button in the plugin list
    }

    public void OnUpdate()
    {
        // called every ~100ms
    }

    public string Name => "Hand Tracker";

    public string Description => "TEMP_DESCRIPTION";

    public string ButtonText => "TEMP_BUTTON_TEXT";

    public string Author => "Steve Olsen";

    public Version Version => new Version(0, 0, 1);

    public MenuItem MenuItem => null;
  }
}

