//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ExploringSuperposition\",\"Name\":\"GenerateRandomBit\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":6,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ExploringSuperposition\",\"Name\":\"GenerateRandomBit\"},\"Attributes\":[],\"SourceFile\":\"/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
#line hidden
namespace ExploringSuperposition
{
    [SourceLocation("/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs", OperationFunctor.Body, 8, -1)]
    public partial class GenerateRandomBit : Operation<QVoid, Result>, ICallable
    {
        public GenerateRandomBit(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GenerateRandomBit";
        String ICallable.FullName => "ExploringSuperposition.GenerateRandomBit";
        public static EntryPointInfo<QVoid, Result> Info => new EntryPointInfo<QVoid, Result>(typeof(GenerateRandomBit));
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        protected ICallable Microsoft__Quantum__Diagnostics__DumpMachine
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset__
        {
            get;
            set;
        }

        public override Func<QVoid, Result> __Body__ => (__in__) =>
        {
#line hidden
            {
#line 9 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                var q = Allocate__.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 10 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Message__.Apply("Initialized qubit:");
#line 11 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Microsoft__Quantum__Diagnostics__DumpMachine.Apply(QVoid.Instance);
#line 12 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Message__.Apply(" ");
#line 13 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(q);
#line 14 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Message__.Apply("Qubit after applying H:");
#line 15 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Microsoft__Quantum__Diagnostics__DumpMachine.Apply(QVoid.Instance);
#line 16 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Message__.Apply(" ");
#line 17 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    var randomBit = Microsoft__Quantum__Intrinsic__M.Apply(q);
#line 18 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Message__.Apply("Qubit after the measurement:");
#line 19 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Microsoft__Quantum__Diagnostics__DumpMachine.Apply(QVoid.Instance);
#line 20 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Message__.Apply(" ");
#line 21 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Reset__.Apply(q);
#line 22 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Message__.Apply("Qubit after resetting:");
#line 23 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Microsoft__Quantum__Diagnostics__DumpMachine.Apply(QVoid.Instance);
#line 24 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    Message__.Apply(" ");
#line 25 "/Users/raunaksingh/Documents/iquhack_2023/develop_with_q#_and_python/ExploringSuperposition/Program.qs"
                    return randomBit;
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(q);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
            this.Microsoft__Quantum__Diagnostics__DumpMachine = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Diagnostics.DumpMachine<>));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.Reset__ = this.__Factory__.Get<ICallable<Qubit, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Reset));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<GenerateRandomBit, QVoid, Result>(QVoid.Instance);
        }
    }
}