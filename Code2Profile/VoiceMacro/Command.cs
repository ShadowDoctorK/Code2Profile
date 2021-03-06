﻿using System;
using System.Collections.Generic;

namespace Code2Profile.VoiceMacro
{
    public class Command
    {
        public string Phrase { get; internal set; } = "";
        public Guid ID { get; internal set; } = Guid.NewGuid();
        public List<MacroAction> MacroActions { get; internal set; } = new List<MacroAction>();
        public VoiceMacroProfileCommandsShortCut Shortcut { get; internal set; } = new VoiceMacroProfileCommandsShortCut() { Key = "None" };
        public bool UseRecognition { get; internal set; } = true;
    }
}
