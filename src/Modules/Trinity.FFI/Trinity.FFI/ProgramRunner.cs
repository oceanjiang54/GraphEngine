﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using Trinity.Storage;

namespace Trinity.FFI
{
    internal class ProgramRunner
    {
        #region Fields
        private ILanguageRuntimeProvider m_runtimeProvider;
        private ConcurrentStack<ILanguageRuntime> m_runtimes;
        #endregion

        public ProgramRunner(ILanguageRuntimeProvider runtime_provider)
        {
            m_runtimeProvider = runtime_provider;
            m_runtimes = new ConcurrentStack<ILanguageRuntime>();
        }

        public string RuntimeName => m_runtimeProvider.Name;

        public void Dispose()
        {
        }

        public void RegisterOperations(IGenericCellOperations storageOperations, IGenericMessagePassingOperations messagePassingOperations)
        {
        }

        public string Run(int methodId, string input)
        {
            throw new NotImplementedException();
        }

        public int RunAsync(int methodId, string input)
        {
            throw new NotImplementedException();
        }

        public int Wait(int handle, int timeout, out string output)
        {
            throw new NotImplementedException();
        }

        internal void LoadProgram(string file)
        {
            throw new NotImplementedException();
        }
    }
}