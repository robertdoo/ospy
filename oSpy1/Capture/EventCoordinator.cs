﻿//
// Copyright (c) 2009 Ole André Vadla Ravnås <oleavr@gmail.com>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Diagnostics;
using System.Threading;

namespace oSpy.Capture
{
    public class EventCoordinator
    {
        private int id = 0;
        private Process process = Process.GetCurrentProcess();

        public UInt32 AllocateId()
        {
            return (UInt32) Interlocked.Increment(ref id);
        }

        public DateTime TimeNow()
        {
            // TODO: not the most precise, but good enough for now
            return DateTime.Now;
        }

        public Event.ExecutionOrigin ExecutionOriginHere()
        {
            return new Event.ExecutionOrigin(process.MainModule.ModuleName, (uint) process.Id, (uint) AppDomain.GetCurrentThreadId());
        }
    }
}
