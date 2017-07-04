﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vfp_search
{
    using CommandLine;
    using CommandLine.Text;

    public class CommandLineOptions
    {
        [Option('f', "fragment", Required = true, HelpText = "Fragment fingerprint file (small).")]
        public string FragmentFile { get; set; }

        [Option('m', "main", Required = true, HelpText = "Main fingerprint file (long).")]
        public string MainFile { get; set; }

        [Option('l', "license", Required = false, HelpText = "License key.", DefaultValue = "TRIAL")]
        public string LicenseKey { get; set; }

        [Option('d', "md", Required = false, HelpText = "Maximal difference between fingerprints.", DefaultValue = 500)]
        public int MaxDifference { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            var help = new HelpText
            {
                Heading = new HeadingInfo("VisioForge Video Fingerprinting SDK signature search tool (can search one fingerprint in another).", "10.0"),
                Copyright = new CopyrightInfo("VisioForge", 2017),
                AdditionalNewLineAfterOption = true,
                AddDashesToOption = true
            };

            help.AddPreOptionsLine("Usage: app -f \"fragment file\" -m \"main file\" options");
            help.AddOptions(this);

            return help;
        }
    }
}
