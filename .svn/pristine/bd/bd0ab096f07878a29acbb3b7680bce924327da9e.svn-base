using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Text;
using System.Reflection;
using System.Collections;

namespace mz.erp.businessrules.comprobantes
{
	public class Evaluator
	{
		const string staticMethodName = "__foo";
		object _Compiled = null;
        /* Silvina 20110727 - Tarea 0000180 */
        private static string[] _defaultReferences = new string[] { GetFullPath("mz.erp.systemframework.dll"), GetFullPath("mz.erp.commontypes.dll"), GetFullPath("mz.erp.dataaccess.dll"), GetFullPath("mz.erp.businessrules.dll"), GetFullPath("mz.erp.exe"), GetFullPath("mz.erp.ui.dll") };
        /* Fin Silvina 20110727 - Tarea 0000180 */
		private static string[] _defaultUsings = new string[] { "mz.erp.systemframework", "mz.erp.commontypes", "mz.erp.commontypes.data", "mz.erp.dataaccess", "mz.erp.businessrules", "mz.erp.businessrules.comprobantes",  "mz.erp.ui.forms" };
		private static Hashtable _evaluatorCache;

		public Evaluator( EvaluatorItem[] items, string[] references, string[] usings ) 
		{
			ConstructEvaluator( items, references, usings );
			
		}

		public Evaluator(Type returnType, string expression, string name, string[] references, string[] usings )
		{
			EvaluatorItem[] items = { new EvaluatorItem( returnType, expression, name ) };
			ConstructEvaluator( items, references, usings  );
		}

		public Evaluator( EvaluatorItem item, string[] references, string[] usings )
		{
			EvaluatorItem[] items = { item };
			ConstructEvaluator( items, references, usings );
		}

		private void ConstructEvaluator( EvaluatorItem[] items, string[] references, string[] usings  )
		{
			ICodeCompiler comp = ( new CSharpCodeProvider().CreateCompiler() );
			CompilerParameters cp = new CompilerParameters();
			cp.ReferencedAssemblies.Add( "system.dll" );
			cp.ReferencedAssemblies.Add( "system.data.dll" );
			cp.ReferencedAssemblies.Add( "system.web.dll" );
			cp.ReferencedAssemblies.Add( "system.xml.dll" );

			foreach( string referenceItem in references ) 
			{
				cp.ReferencedAssemblies.Add( referenceItem );
			}

			cp.GenerateExecutable = false;
			cp.GenerateInMemory = true;

			CompilerResults cr = comp.CompileAssemblyFromSource( cp, GetCode( items, references, usings ) );
			if ( cr.Errors.HasErrors ) 	
			{
				StringBuilder error = new StringBuilder();
				error.Append( "Error Compilando Expresión: " );

				foreach ( CompilerError err in cr.Errors ) 	
				{
					error.AppendFormat( "{0}\n", err.ErrorText );
				}
				throw new Exception( "Error Compilando Expresión: " + error.ToString() );
			}
			Assembly a = cr.CompiledAssembly;
			_Compiled = a.CreateInstance( "Evaluator._Evaluator" );
		}

		private string GetCode( EvaluatorItem[] items, string[] references, string[] usings  )
		{
			StringBuilder code = new StringBuilder();
			code.Append("using System; \n" );
			code.Append( "using System.Data; \n" );
			code.Append( "using System.Data.SqlClient; \n" );
			code.Append( "using System.Data.OleDb; \n" );
			code.Append( "using System.Xml; \n" );
			code.Append( "using System.Web.UI; \n" );
			
			foreach( string usingItem in usings ) 
			{
				code.Append( "using " + usingItem + "; \n" );
			}

			code.Append( "namespace Evaluator { \n");
			code.Append( "  public class _Evaluator { \n");

			foreach( EvaluatorItem item in items )
			{
				code.AppendFormat( "    public {0} {1}( object sender ) ", 	item.ReturnType.Name, item.Name );
				code.Append( "{ " );
				code.AppendFormat( "      {0}; ", item.Expression );
				code.Append( "}\n" );
			}
			code.Append( "} }" );

			return code.ToString();
		}

		public int EvaluateInt( string name, object sender )
		{
			return ( int )Evaluate( name, sender );
		}


		public decimal EvaluateDecimal( string name, object sender )
		{
			return ( decimal )Evaluate( name, sender );
		}
		
		public string EvaluateString( string name, object sender )
		{
			return ( string )Evaluate( name, sender );
		}

		public bool EvaluateBool( string name, object sender )
		{
			return ( bool )Evaluate( name, sender );
		}

		public object Evaluate( string name, object sender )
		{
			MethodInfo mi = _Compiled.GetType().GetMethod( name );
			return mi.Invoke( _Compiled, new object[]{ sender } );
		}

		public static int EvaluateToInteger( string code, string[] references, string[] usings, object sender ) 
		{
			Evaluator eval = GetEvaluator( typeof( int ), code, staticMethodName, references, usings );
			return ( int )eval.Evaluate( staticMethodName, sender );
		}

		public static Evaluator GetEvaluator( Type returnType, string code, string name, string[] references, string[] usings )
		{
			Evaluator eval;

			if ( _evaluatorCache == null )
			{
				_evaluatorCache = new Hashtable();
			}

			if ( _evaluatorCache.ContainsKey( code ) )
			{
				eval = ( Evaluator )_evaluatorCache[ code ];
			}
			else
			{
				eval = new Evaluator( returnType, code, name, references, usings );
				_evaluatorCache.Add( code, eval );
			}

			return eval;
		}

		public static int EvaluateToInteger( string code, object sender ) 
		{
			Evaluator eval = new Evaluator( typeof( int ), code, staticMethodName, _defaultReferences, _defaultUsings );
			return ( int )eval.Evaluate( staticMethodName, sender );
		}

		public static decimal EvaluateToDecimal( string code, object sender ) 
		{
			Evaluator eval = new Evaluator( typeof( decimal ), code, staticMethodName, _defaultReferences, _defaultUsings );
			return ( decimal )eval.Evaluate( staticMethodName, sender );
		}


		public static string EvaluateToString( string code, object sender )
		{
			Evaluator eval = GetEvaluator( typeof( string ), code, staticMethodName, _defaultReferences, _defaultUsings );
			return ( string )eval.Evaluate( staticMethodName, sender );
		}

		public static bool EvaluateToBool( string code, object sender )
		{
			Evaluator eval = GetEvaluator( typeof( bool ), code, staticMethodName, _defaultReferences, _defaultUsings );
			return ( bool )eval.Evaluate(staticMethodName, sender );
		}

		public static bool EvaluateToBool( string code, object sender, bool Default)
		{
			try 
			{
				Evaluator eval = GetEvaluator( typeof( bool ), code, staticMethodName, _defaultReferences, _defaultUsings );
				return ( bool )eval.Evaluate(staticMethodName, sender );
			}
			catch 
			{
				return Default;
			}
		}


		public static object EvaluateToObject( string code, object sender )
		{
			Evaluator eval = GetEvaluator( typeof( object ), code, staticMethodName, _defaultReferences, _defaultUsings );
			return eval.Evaluate( staticMethodName, sender );
		}

		public static string EvaluateToString( string code, string[] references, string[] usings, object sender )
		{
			Evaluator eval = GetEvaluator( typeof( string ), code, staticMethodName, references, usings );
			return ( string )eval.Evaluate( staticMethodName, sender );
		}
		
		public static bool EvaluateToBool( string code, string[] references, string[] usings, object sender )
		{
			Evaluator eval = GetEvaluator( typeof( bool ), code, staticMethodName, references, usings );
			return ( bool )eval.Evaluate( staticMethodName, sender );
		}
		
		public static object EvaluateToObject( string code, string[] references, string[] usings, object sender )
		{
			Evaluator eval = GetEvaluator( typeof( object ), code, staticMethodName, references, usings );
			return eval.Evaluate( staticMethodName, sender );
		}


        /* Silvina 20110727 - Tarea 0000180 */
        private static string GetFullPath(string fileName)
        {
            //return System.IO.Path.Combine(Environment.CurrentDirectory, fileName);
            System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(System.Windows.Forms.Application.StartupPath);
            return BuscarArchivo(d, fileName);
        }

        private static string BuscarArchivo(System.IO.DirectoryInfo Dir, string FileName)
        {
            System.IO.FileInfo[] file = Dir.GetFiles(FileName);
            if (file.Length != 0)
                return System.IO.Path.Combine(file[0].DirectoryName, FileName);
            else
            {
                System.IO.DirectoryInfo[] d = Dir.GetDirectories();
                foreach (System.IO.DirectoryInfo s in d)
                {
                    string a = BuscarArchivo(s,FileName);
                    if (!string.IsNullOrEmpty(a))
                        return a;
                }
            }
            return string.Empty;
        }
        /* Fin Silvina 20110727 - Tarea 0000180 */
	}

  public class EvaluatorItem
  {
	  public Type ReturnType;
	  public string Name;
	  public string Expression;

	  public EvaluatorItem( Type returnType, string expression, string name )
	  {
		  ReturnType = returnType;
		  Expression = expression;
		  Name = name;
	  }

  }
}
