﻿#region Copyright and license information
// Copyright 2012 Jon Skeet
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Eduasync
{
    class GeneratedProgram
    {
        private static void Main(string[] args)
        {
            var task = DoNonsenseAsync(5);

            Console.WriteLine("Returned from async method");

            Console.WriteLine("Result: {0}", task.Result);
        }

        private static Task<int> DoNonsenseAsync(int count)
        {
            DoNonsenseAsyncStateMachine stateMachine = default(DoNonsenseAsyncStateMachine);
            stateMachine.count = count;
            stateMachine.builder = AsyncTaskMethodBuilder<int>.Create();
            stateMachine.MoveNext();
            return stateMachine.builder.Task;
        }

        // This would normally be private, but it's called from DoNonsenseAsyncStateMachine...
        public static Task<int> WaitAndReturnRandomNumber(Random rng)
        {
            WaitAndReturnRandomNumberStateMachine stateMachine = default(WaitAndReturnRandomNumberStateMachine);
            stateMachine.rng = rng;
            stateMachine.builder = AsyncTaskMethodBuilder<int>.Create();
            stateMachine.MoveNext();
            return stateMachine.builder.Task;
        }
    }
}
