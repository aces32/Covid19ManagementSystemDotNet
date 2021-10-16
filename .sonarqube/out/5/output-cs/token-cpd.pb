›#
ÅC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.API\Controllers\AdministratorController.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
API% (
.( )
Controllers) 4
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status200OK& 1
)1 2
]2 3
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status204NoContent& 8
)8 9
]9 :
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status404NotFound& 7
)7 8
]8 9
public 

class #
AdministratorController (
:) *
ControllerBase+ 9
{ 
private 
readonly 
	IMediator "
	_mediator# ,
;, -
public #
AdministratorController &
(& '
	IMediator' 0
mediator1 9
)9 :
{ 	
	_mediator 
= 
mediator  
;  !
} 	
[!! 	
HttpPost!!	 
(!! 
$str!! ;
,!!; <
Name!!= A
=!!B C
$str!!D Z
)!!Z [
]!![ \
public"" 
async"" 
Task"" 
<"" 
ActionResult"" &
<""& '/
#AllocateBookingSpaceCommandResponse""' J
>""J K
>""K L
Create""M S
(""S T'
AllocateBookingSpaceCommand""T o(
allocateBookingSpaceCommand	""p ã
)
""ã å
{## 	
var$$ 
response$$ 
=$$ 
await$$  
	_mediator$$! *
.$$* +
Send$$+ /
($$/ 0'
allocateBookingSpaceCommand$$0 K
)$$K L
;$$L M
return%% 
Ok%% 
(%% 
response%% 
)%% 
;%%  
}&& 	
[,, 	
HttpGet,,	 
(,, 
$str,, @
,,,@ A
Name,,B F
=,,G H
$str,,I e
),,e f
],,f g
public-- 
async-- 
Task-- 
<-- 
ActionResult-- &
<--& '
List--' +
<--+ ,"
AvailableBookingListVm--, B
>--B C
>--C D
>--D E
Get--F I
(--I J
)--J K
{.. 	
var// 
response// 
=// 
await//  
	_mediator//! *
.//* +
Send//+ /
(/// 0
new//0 3+
GetAvailableBookingDetailsQuery//4 S
(//S T
)//T U
)//U V
;//V W
return00 
Ok00 
(00 
response00 
)00 
;00  
}11 	
[77 	
HttpGet77	 
(77 
$str77 8
,778 9
Name77: >
=77? @
$str77A U
)77U V
]77V W
public88 
async88 
Task88 
<88 
ActionResult88 &
<88& '
List88' +
<88+ ,"
BookingsReportsListsVm88, B
>88B C
>88C D
>88D E
Get88F I
(88I J
DateTimeOffset88J X
	startDate88Y b
,88b c
DateTimeOffset88d r
endDate88s z
,88z {
int88| 
page
88Ä Ñ
,
88Ñ Ö
int
88Ü â
size
88ä é
)
88é è
{99 	
var:: #
getBookingsReportsQuery:: '
=::( )
new::* -#
GetBookingsReportsQuery::. E
{;; 
	StartDate<< 
=<< 
	startDate<< %
,<<% &
EndDate== 
=== 
endDate== !
,==! "
Page>> 
=>> 
page>> 
,>> 
Size?? 
=?? 
size?? 
}@@ 
;@@ 
varAA 
responseAA 
=AA 
awaitAA  
	_mediatorAA! *
.AA* +
SendAA+ /
(AA/ 0#
getBookingsReportsQueryAA0 G
)AAG H
;AAH I
returnBB 
OkBB 
(BB 
responseBB 
)BB 
;BB  
}CC 	
}DD 
}EE ”"
~C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.API\Controllers\IndividualController.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
API% (
.( )
Controllers) 4
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status200OK& 1
)1 2
]2 3
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status204NoContent& 8
)8 9
]9 :
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status404NotFound& 7
)7 8
]8 9
public 

class  
IndividualController %
:& '
ControllerBase( 6
{ 
private 
readonly 
	IMediator "
	_mediator# ,
;, -
public  
IndividualController #
(# $
	IMediator$ -
mediator. 6
)6 7
{ 	
	_mediator 
= 
mediator  
;  !
} 	
[!! 	
HttpPost!!	 
(!! 
$str!! 1
,!!1 2
Name!!3 7
=!!8 9
$str!!: I
)!!I J
]!!J K
public"" 
async"" 
Task"" 
<"" 
ActionResult"" &
<""& '(
BookCovidTestCommandResponse""' C
>""C D
>""D E
Create""F L
(""L M 
BookCovidTestCommand""M a 
bookCovidTestCommand""b v
)""v w
{## 	
var$$ 
response$$ 
=$$ 
await$$  
	_mediator$$! *
.$$* +
Send$$+ /
($$/ 0 
bookCovidTestCommand$$0 D
)$$D E
;$$E F
return%% 
Ok%% 
(%% 
response%% 
)%% 
;%%  
}&& 	
[-- 	
HttpPut--	 
(-- 
$str-- 3
,--3 4
Name--5 9
=--: ;
$str--< N
)--N O
]--O P
public.. 
async.. 
Task.. 
<.. 
ActionResult.. &
<..& '+
CancelBookedTestCommandResponse..' F
>..F G
>..G H
Update..I O
(..O P#
CancelBookedTestCommand..P g#
cancelBookedTestCommand..h 
)	.. Ä
{// 	
var00 
canceledBookings00  
=00! "
await00# (
	_mediator00) 2
.002 3
Send003 7
(007 8#
cancelBookedTestCommand008 O
)00O P
;00P Q
return11 
Ok11 
(11 
canceledBookings11 &
)11& '
;11' (
}22 	
[:: 	
HttpGet::	 
(:: 
$str:: F
,::F G
Name::H L
=::M N
$str::O t
)::t u
]::u v
public;; 
async;; 
Task;; 
<;; 
ActionResult;; &
<;;& ' 
IndividualInfoListVm;;' ;
>;;; <
>;;< =
Get;;> A
(;;A B
string;;B H
emailAddress;;I U
,;;U V
string;;W ]
mobileNumber;;^ j
);;j k
{<< 	
var== /
#getIndividualInfoByMobileNoAndEmail== 3
===4 5
new==6 94
(GetIndividualInfoByMobileNoAndEmailQuery==: b
{>> "
IndividualEmailAddress?? &
=??' (
emailAddress??) 5
.??5 6
Trim??6 :
(??: ;
)??; <
,??< ="
IndividualMobileNumber@@ &
=@@' (
mobileNumber@@) 5
.@@5 6
Trim@@6 :
(@@: ;
)@@; <
}AA 
;AA 
varCC 
responseCC 
=CC 
awaitCC  
	_mediatorCC! *
.CC* +
SendCC+ /
(CC/ 0/
#getIndividualInfoByMobileNoAndEmailCC0 S
)CCS T
;CCT U
returnEE 
OkEE 
(EE 
responseEE 
)EE 
;EE  
}FF 	
}GG 
}HH ›
ÇC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.API\Controllers\IndividualLabsController.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
API% (
.( )
Controllers) 4
{ 
[		 
Route		 

(		
 
$str		 
)		 
]		 
[

 
ApiController

 
]

 
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status200OK& 1
)1 2
]2 3
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status204NoContent& 8
)8 9
]9 :
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status404NotFound& 7
)7 8
]8 9
public 

class $
IndividualLabsController )
:* +
ControllerBase, :
{ 
private 
readonly 
	IMediator "
	_mediator# ,
;, -
public $
IndividualLabsController '
(' (
	IMediator( 1
mediator2 :
): ;
{ 	
	_mediator 
= 
mediator  
;  !
} 	
[ 	
HttpPut	 
( 
$str 5
,5 6
Name7 ;
=< =
$str> N
)N O
]O P
public 
async 
Task 
< 
ActionResult &
<& ')
SetTestOutcomeCommandResponse' D
>D E
>E F
UpdateG M
(M N!
SetTestOutcomeCommandN c!
setTestOutcomeCommandd y
)y z
{ 	
var 
response 
= 
await  
	_mediator! *
.* +
Send+ /
(/ 0!
setTestOutcomeCommand0 E
)E F
;F G
return   
Ok   
(   
response   
)   
;    
}!! 	
}$$ 
}%% Œ
|C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.API\Controllers\LocationController.cs
	namespace

 	
COVID_19PCR


 
.

 
TestManagement

 $
.

$ %
API

% (
.

( )
Controllers

) 4
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status200OK& 1
)1 2
]2 3
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status204NoContent& 8
)8 9
]9 :
[  
ProducesResponseType 
( 
StatusCodes %
.% &
Status404NotFound& 7
)7 8
]8 9
public 

class 
LocationController #
:$ %
ControllerBase& 4
{ 
private 
readonly 
	IMediator "
	_mediator# ,
;, -
public 
LocationController !
(! "
	IMediator" +
mediator, 4
)4 5
{ 	
	_mediator 
= 
mediator  
;  !
} 	
[ 	
HttpGet	 
( 
Name 
= 
$str 2
)2 3
]3 4
public 
async 
Task 
< 
ActionResult &
<& '
List' +
<+ ,#
AvailableLocationListVm, C
>C D
>D E
>E F$
GetAllAvailableLocationsG _
(_ `
)` a
{   	
var!! 
dtos!! 
=!! 
await!! 
	_mediator!! &
.!!& '
Send!!' +
(!!+ ,
new!!, /)
GetAllAvailableLocationsQuery!!0 M
(!!M N
)!!N O
)!!O P
;!!P Q
return"" 
Ok"" 
("" 
dtos"" 
)"" 
;"" 
}## 	
}$$ 
}%% ˚!
ÉC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.API\MiddleWare\ExceptionHandlerMiddleware.cs
	namespace

 	
COVID_19PCR


 
.

 
TestManagement

 $
.

$ %
API

% (
.

( )

MiddleWare

) 3
{ 
public 

class &
ExceptionHandlerMiddleware +
{ 
private 
readonly 
RequestDelegate (
_next) .
;. /
public &
ExceptionHandlerMiddleware )
() *
RequestDelegate* 9
next: >
)> ?
{ 	
_next 
= 
next 
; 
} 	
public 
async 
Task 
Invoke  
(  !
HttpContext! ,
context- 4
)4 5
{ 	
try 
{ 
await 
_next 
( 
context #
)# $
;$ %
} 
catch 
( 
	Exception 
ex 
)  
{ 
await 
ConvertException &
(& '
context' .
,. /
ex0 2
)2 3
;3 4
} 
} 	
private!! 
static!! 
Task!! 
ConvertException!! ,
(!!, -
HttpContext!!- 8
context!!9 @
,!!@ A
	Exception!!B K
	exception!!L U
)!!U V
{"" 	
HttpStatusCode## 
httpStatusCode## )
=##* +
HttpStatusCode##, :
.##: ;
InternalServerError##; N
;##N O
context%% 
.%% 
Response%% 
.%% 
ContentType%% (
=%%) *
$str%%+ =
;%%= >
var'' 
result'' 
='' 
string'' 
.''  
Empty''  %
;''% &
switch)) 
()) 
	exception)) 
))) 
{** 
case++ 
ValidationException++ (
validationException++) <
:++< =
httpStatusCode,, "
=,,# $
HttpStatusCode,,% 3
.,,3 4

BadRequest,,4 >
;,,> ?
result-- 
=-- 
JsonConvert-- (
.--( )
SerializeObject--) 8
(--8 9
validationException--9 L
.--L M
ValdationErrors--M \
)--\ ]
;--] ^
break.. 
;.. 
case// 
BadRequestException// (
badRequestException//) <
://< =
httpStatusCode00 "
=00# $
HttpStatusCode00% 3
.003 4

BadRequest004 >
;00> ?
result11 
=11 
badRequestException11 0
.110 1
Message111 8
;118 9
break22 
;22 
case33 
NotFoundException33 &
notFoundException33' 8
:338 9
httpStatusCode44 "
=44# $
HttpStatusCode44% 3
.443 4
NotFound444 <
;44< =
break55 
;55 
case66 
	Exception66 
ex66 !
:66! "
httpStatusCode77 "
=77# $
HttpStatusCode77% 3
.773 4
InternalServerError774 G
;77G H
break88 
;88 
}99 
context;; 
.;; 
Response;; 
.;; 

StatusCode;; '
=;;( )
(;;* +
int;;+ .
);;. /
httpStatusCode;;/ =
;;;= >
if== 
(== 
result== 
==== 
string==  
.==  !
Empty==! &
)==& '
{>> 
result?? 
=?? 
JsonConvert?? $
.??$ %
SerializeObject??% 4
(??4 5
new??5 8
{??9 :
error??; @
=??A B
	exception??C L
.??L M
Message??M T
}??U V
)??V W
;??W X
}@@ 
returnBB 
contextBB 
.BB 
ResponseBB #
.BB# $

WriteAsyncBB$ .
(BB. /
resultBB/ 5
)BB5 6
;BB6 7
}CC 	
}DD 
}EE Ó
}C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.API\MiddleWare\MiddlewareExtensions.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
API% (
.( )

MiddleWare) 3
{ 
public		 

static		 
class		  
MiddlewareExtensions		 ,
{

 
public 
static 
IApplicationBuilder )%
UseCustomExceptionHandler* C
(C D
thisD H
IApplicationBuilderI \
builder] d
)d e
{ 	
return 
builder 
. 
UseMiddleware (
<( )&
ExceptionHandlerMiddleware) C
>C D
(D E
)E F
;F G
} 	
} 
} è
eC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.API\Program.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
API% (
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	
CreateHostBuilder 
( 
args "
)" #
.# $
Build$ )
() *
)* +
.+ ,
Run, /
(/ 0
)0 1
;1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5
} 
) 
. 

UseSerilog 
( 
Logging %
.% &
ConfigureLogger& 5
)5 6
;6 7
} 
} Ù)
eC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.API\Startup.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
API% (
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public   
void   
ConfigureServices   %
(  % &
IServiceCollection  & 8
services  9 A
)  A B
{!! 	
services"" 
."" "
AddApplicationServices"" +
(""+ ,
)"", -
;""- .
services## 
.## "
AddPersistenceServices## +
(##+ ,
Configuration##, 9
)##9 :
;##: ;
services$$ 
.$$ 
AddControllers$$ #
($$# $
)$$$ %
;$$% &
services%% 
.%% 
AddCors%% 
(%% 
options%% $
=>%%% '
{&& 
options'' 
.'' 
	AddPolicy'' !
(''! "
$str''" (
,''( )
builder''* 1
=>''2 4
builder''5 <
.''< =
AllowAnyOrigin''= K
(''K L
)''L M
.''M N
AllowAnyHeader''N \
(''\ ]
)''] ^
.''^ _
AllowAnyMethod''_ m
(''m n
)''n o
)''o p
;''p q
}(( 
)(( 
;(( 

AddSwagger** 
(** 
services** 
)**  
;**  !
}++ 	
private.. 
static.. 
void.. 

AddSwagger.. &
(..& '
IServiceCollection..' 9
services..: B
)..B C
{// 	
services00 
.00 
AddSwaggerGen00 "
(00" #
c00# $
=>00% '
{11 
c33 
.33 

SwaggerDoc33 
(33 
$str33 !
,33! "
new33# &
OpenApiInfo33' 2
{333 4
Title335 :
=33; <
$str33= ]
,33] ^
Version33_ f
=33g h
$str33i m
}33n o
)33o p
;33p q
c55 
.55 
EnableAnnotations55 #
(55# $
)55$ %
;55% &
var66 
xmlCommentFile66 "
=66# $
$"66% '
{66' (
Assembly66( 0
.660 1 
GetExecutingAssembly661 E
(66E F
)66F G
.66G H
GetName66H O
(66O P
)66P Q
.66Q R
Name66R V
}66V W
$str66W [
"66[ \
;66\ ]
var77 
xmlCommentsFullPath77 '
=77( )
Path77* .
.77. /
Combine77/ 6
(776 7

AppContext777 A
.77A B
BaseDirectory77B O
,77O P
xmlCommentFile77Q _
)77_ `
;77` a
c88 
.88 
IncludeXmlComments88 $
(88$ %
xmlCommentsFullPath88% 8
)888 9
;889 :
}:: 
):: 
;:: 
services<< 
.<< *
AddSwaggerGenNewtonsoftSupport<< 3
(<<3 4
)<<4 5
;<<5 6
}>> 	
publicBB 
voidBB 
	ConfigureBB 
(BB 
IApplicationBuilderBB 1
appBB2 5
,BB5 6
IWebHostEnvironmentBB7 J
envBBK N
)BBN O
{CC 	
ifDD 
(DD 
envDD 
.DD 
IsDevelopmentDD !
(DD! "
)DD" #
)DD# $
{EE 
appFF 
.FF %
UseDeveloperExceptionPageFF -
(FF- .
)FF. /
;FF/ 0
}GG 
appII 
.II 

UseSwaggerII 
(II 
)II 
;II 
appKK 
.KK 
UseSwaggerUIKK 
(KK 
cKK 
=>KK !
cKK" #
.KK# $
SwaggerEndpointKK$ 3
(KK3 4
$strKK4 N
,KKN O
$strKKP s
)KKs t
)KKt u
;KKu v
appMM 
.MM 
UseHttpsRedirectionMM #
(MM# $
)MM$ %
;MM% &
appOO 
.OO 

UseRoutingOO 
(OO 
)OO 
;OO 
appQQ 
.QQ %
UseCustomExceptionHandlerQQ )
(QQ) *
)QQ* +
;QQ+ ,
appSS 
.SS 
UseCorsSS 
(SS 
$strSS 
)SS 
;SS  
appUU 
.UU 
UseAuthorizationUU  
(UU  !
)UU! "
;UU" #
appWW 
.WW 
UseEndpointsWW 
(WW 
	endpointsWW &
=>WW' )
{XX 
	endpointsYY 
.YY 
MapControllersYY (
(YY( )
)YY) *
;YY* +
}ZZ 
)ZZ 
;ZZ 
}[[ 	
}\\ 
}]] 