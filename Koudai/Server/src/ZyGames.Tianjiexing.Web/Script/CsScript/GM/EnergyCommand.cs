﻿/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
using ZyGames.Framework;
using ZyGames.Framework.Common;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Tianjiexing.Model;

namespace ZyGames.Tianjiexing.BLL.GM
{
    /// <summary>
    /// 增加精力命令
    /// </summary>
    public class EnergyCommand : TjBaseCommand
    {
        protected override void ProcessCmd(string[] args)
        {
            short energyNum = args.Length > 0 ? args[0].Trim().ToShort() : (short)1;
            Process(UserID, energyNum);
        }

        private void Process(string userID, short energyNum)
        {
            GameUser currentUser = new PersonalCacheStruct<GameUser>().FindKey(userID);
            if (currentUser != null)
            {
                currentUser.EnergyNum = MathUtils.Addition(currentUser.EnergyNum, energyNum, short.MaxValue);
            }//currentUser.Update();
        }
    }
}