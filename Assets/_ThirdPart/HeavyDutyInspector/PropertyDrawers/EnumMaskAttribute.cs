/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

//----------------------------------------------
//            Heavy-Duty Inspector
//      Copyright © 2014 - 2015  Illogika
//----------------------------------------------
using UnityEngine;

namespace HeavyDutyInspector
{

	public class EnumMaskAttribute : PropertyAttribute {
		
		/// <summary>
		/// Displays an enum field as an Enum Mask.
		/// *** Caution! When setting an Enum mask to Everything, in Unity and then removing one of the values from the mask, the Enum mask goes into the negative and its value becomes corrupted until you reset it to Nothing. ***
		/// </summary>
		public EnumMaskAttribute()
		{
			
		}
	}
	
}
	
