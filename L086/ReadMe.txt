1)	Windows Server
2)	Windows 10
a)	Win10安装IIS并配置ASP.NET 4.0
b)	添加MIME类型：扩展名“.svc”，MIME类型 “application/octet-stream”
c)	在“Handler Mappings(处理程序映射)”中添加Managed Handler(添加托管处理程序)
Request path: *.svc
Type: System.ServiceModel.Activation.HttpHandler
Name: svc-Integrated
d)	添加system.serviceModel
e)	删除 serviceHostingEnvironment
3)	inetmgr
