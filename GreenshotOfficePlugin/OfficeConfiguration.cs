﻿/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2007-2015 Thomas Braun, Jens Klingen, Robin Krom
 * 
 * For more information see: http://getgreenshot.org/
 * The Greenshot project is hosted on Sourceforge: http://sourceforge.net/projects/greenshot/
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Dapplo.Config.Ini;
using System.ComponentModel;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace GreenshotOfficePlugin {
	/// <summary>
	/// Specifies which EmailFormat the email needs to use
	/// </summary>
	public enum EmailFormat {
		Text,
		HTML
	}
	/// <summary>
	/// Description of CoreConfiguration.
	/// </summary>
	[IniSection("Office"), Description("Greenshot Office configuration")]
	public class OfficeConfiguration : IIniSection<OfficeConfiguration> {
		[Description("Default type for emails. (Text, HTML)"), DefaultValue(EmailFormat.HTML)]
		EmailFormat OutlookEmailFormat {
			get;
			set;
		}
		[Description("Email subject pattern, works like the OutputFileFilenamePattern"), DefaultValue("${title}")]
		string EmailSubjectPattern {
			get;
			set;
		}
		[Description("Default value for the to in emails that are created")]
		string EmailTo {
			get;
			set;
		}
		[Description("Default value for the CC in emails that are created")]
		string EmailCC {
			get;
			set;
		}
		[Description("Default value for the BCC in emails that are created")]
		string EmailBCC {
			get;
			set;
		}
		[Description("For Outlook: Allow export in meeting items"), DefaultValue(false)]
		bool OutlookAllowExportInMeetings {
			get;
			set;
		}
		[Description("For Word: Lock the aspect ratio of the image"), DefaultValue(true)]
		bool WordLockAspectRatio {
			get;
			set;
		}
		[Description("For Powerpoint: Lock the aspect ratio of the image"), DefaultValue(true)]
		bool PowerpointLockAspectRatio {
			get;
			set;
		}
		[Description("For Powerpoint: Slide layout, changing this to a wrong value will fallback on ppLayoutBlank!!"), DefaultValue(PowerPoint.PpSlideLayout.ppLayoutPictureWithCaption)]
		PowerPoint.PpSlideLayout PowerpointSlideLayout {
			get;
			set;
		}

	}
}