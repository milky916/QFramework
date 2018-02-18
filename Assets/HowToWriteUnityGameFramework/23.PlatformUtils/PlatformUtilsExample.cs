﻿/****************************************************************************
 * Copyright (c) 2018 liangxie
 * 
 * http://liangxiegame.com
 * https://github.com/liangxiegame/QFramework
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 ****************************************************************************/

using UnityEngine;

namespace QFramework.Example
{
	public class PlatformUtilsExample : MonoBehaviour
	{
		// Use this for initialization
		private void Start()
		{
			var sTrAngeNamingVariable = "a variable";
#if UNITY_IOS || UNITY_ANDROID || UNITY_EDITOR
			sTrAngeNamingVariable = "a!value";
#else
			sTrAngeNamingVariable = "other value";
#endif

			if (Platform.IsiOS || Platform.IsAndroid || Platform.IsEditor)
			{
				sTrAngeNamingVariable = "a!value";
			}
			else
			{
				sTrAngeNamingVariable = "other value";
			}

			Log.I(sTrAngeNamingVariable);
		}
	}
}