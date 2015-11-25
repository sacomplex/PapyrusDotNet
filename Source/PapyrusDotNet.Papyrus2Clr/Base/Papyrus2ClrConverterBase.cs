﻿using Mono.Cecil;
using PapyrusDotNet.Common.Interfaces;
using PapyrusDotNet.Converters.Papyrus2Clr.Implementations;

namespace PapyrusDotNet.Converters.Papyrus2Clr.Base
{
    public abstract class Papyrus2ClrConverterBase : IPapyrusOutputConverter
    {
        protected abstract ClrAssemblyOutput ConvertAssembly(PapyrusAssemblyInput input);

        protected INamespaceResolver NamespaceResolver { get; }
        protected ITypeReferenceResolver TypeReferenceResolver { get; }

        protected Papyrus2ClrConverterBase(INamespaceResolver namespaceResolver, ITypeReferenceResolver typeReferenceResolver)
        {
            NamespaceResolver = namespaceResolver;
            TypeReferenceResolver = typeReferenceResolver;
        }

        public IAssemblyOutput Convert(IAssemblyInput input)
        {
            return ConvertAssembly(input as PapyrusAssemblyInput);
        }
    }

  
}