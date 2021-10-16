ý&
xC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Infrastructure\Logging\Logging.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Infrastructure% 3
.3 4
Logging4 ;
{ 
public 

static 
class 
Logging 
{ 
public 
static 
Action 
< 
HostBuilderContext /
,/ 0
LoggerConfiguration1 D
>D E
ConfigureLoggerF U
=>V X
( 
hostBuilderContext 
,  
loggerConfiguration! 4
)4 5
=>6 8
{ 
var 
env 
= 
hostBuilderContext ,
., -
HostingEnvironment- ?
;? @
var 
serviceName 
=  !
hostBuilderContext" 4
.4 5
Configuration5 B
.B C
GetValueC K
<K L
stringL R
>R S
(S T
$strT j
)j k
;k l
loggerConfiguration #
.# $
MinimumLevel$ 0
.0 1
Information1 <
(< =
)= >
. 
Enrich 
. 
FromLogContext &
(& '
)' (
. 
Enrich 
. 
WithProperty $
($ %
$str% 6
,6 7
env8 ;
.; <
ApplicationName< K
)K L
. 
Enrich 
. 
WithProperty $
($ %
$str% 6
,6 7
env8 ;
.; <
EnvironmentName< K
)K L
. 
Enrich 
.  
WithExceptionDetails ,
(, -
)- .
. 
MinimumLevel 
. 
Override &
(& '
$str' 2
,2 3
LogEventLevel4 A
.A B
WarningB I
)I J
.   
MinimumLevel   
.   
Override   &
(  & '
$str  ' 8
,  8 9
LogEventLevel  : G
.  G H
Warning  H O
)  O P
.!! 
MinimumLevel!! 
.!! 
Override!! &
(!!& '
$str!!' C
,!!C D
LogEventLevel!!E R
.!!R S
Information!!S ^
)!!^ _
."" 
WriteTo"" 
."" 
File"" 
("" 
new"" !
JsonFormatter""" /
(""/ 0
)""0 1
,""1 2
@$"""3 6
$str""6 9
{""9 :
serviceName"": E
}""E F
$str""F L
{""L M
serviceName""M X
}""X Y
$str""Y Z
{""Z [
DateTime""[ c
.""c d
Today""d i
:""i j
$str""j t
}""t u
$str""u z
"""z {
)""{ |
.## 
WriteTo## 
.## 
Console##  
(##  !
)##! "
;##" #
if%% 
(%% 
hostBuilderContext%% &
.%%& '
HostingEnvironment%%' 9
.%%9 :
IsDevelopment%%: G
(%%G H
)%%H I
)%%I J
{&& 
loggerConfiguration'' '
.''' (
MinimumLevel''( 4
.''4 5
Override''5 =
(''= >
$str''> P
,''P Q
LogEventLevel''R _
.''_ `
Debug''` e
)''e f
;''f g
}(( 
var** 

elasticUri** 
=**  
hostBuilderContext**! 3
.**3 4
Configuration**4 A
.**A B
GetValue**B J
<**J K
string**K Q
>**Q R
(**R S
$str**S g
)**g h
;**h i
if,, 
(,, 
!,, 
string,, 
.,, 
IsNullOrEmpty,, )
(,,) *

elasticUri,,* 4
),,4 5
),,5 6
{-- 
loggerConfiguration.. '
...' (
WriteTo..( /
.../ 0
Elasticsearch..0 =
(..= >
new00 $
ElasticsearchSinkOptions00 0
(000 1
new001 4
Uri005 8
(008 9

elasticUri009 C
)00C D
)00D E
{11  
AutoRegisterTemplate22 ,
=22- .
true22/ 3
,223 4'
AutoRegisterTemplateVersion33 3
=334 5'
AutoRegisterTemplateVersion336 Q
.33Q R
ESv733R V
,33V W
IndexFormat44 #
=44$ %
$str44& D
,44D E 
MinimumLogEventLevel55 ,
=55- .
LogEventLevel55/ <
.55< =
Debug55= B
}66 
)77 
;77 
}88 
}99 
;99 
}:: 
};; 