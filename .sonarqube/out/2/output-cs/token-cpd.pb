ö
ÑC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\ApplicationServiceRegistration.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
{ 
public		 

static		 
class		 *
ApplicationServiceRegistration		 6
{

 
public 
static 
IServiceCollection ("
AddApplicationServices) ?
(? @
this@ D
IServiceCollectionE W
servicesX `
)` a
{ 	
services 
. 
AddAutoMapper "
(" #
Assembly# +
.+ , 
GetExecutingAssembly, @
(@ A
)A B
)B C
;C D
services 
. 

AddMediatR 
(  
Assembly  (
.( ) 
GetExecutingAssembly) =
(= >
)> ?
)? @
;@ A
services 
. 
AddSwaggerGen "
(" #
c# $
=>% '
{ 
var 
xmlCommentFile "
=# $
$"% '
{' (
Assembly( 0
.0 1 
GetExecutingAssembly1 E
(E F
)F G
.G H
GetNameH O
(O P
)P Q
.Q R
NameR V
}V W
$strW [
"[ \
;\ ]
var 
xmlCommentsFullPath '
=( )
Path* .
.. /
Combine/ 6
(6 7

AppContext7 A
.A B
BaseDirectoryB O
,O P
xmlCommentFileQ _
)_ `
;` a
c 
. 
IncludeXmlComments $
($ %
xmlCommentsFullPath% 8
)8 9
;9 :
} 
) 
; 
return 
services 
; 
} 	
} 
} ◊
ùC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Contracts\Persistence\IAdminBookingAllocationRepository.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
	Contracts1 :
.: ;
Persistence; F
{		 
public

 

	interface

 -
!IAdminBookingAllocationRepository

 6
:

7 8
IAsyncRepository

9 I
<

I J"
AdminBookingAllocation

J `
>

` a
{ 
Task 
< "
AdminBookingAllocation #
># $?
3GetAdminBookingAllocationByLocationIdandBookingDate% X
(X Y
intY \

locationID] g
,g h
DateTimeOffseti w
bookingDate	x É
)
É Ñ
;
Ñ Ö
Task 
< 
List 
< "
AdminBookingAllocation (
>( )
>) *)
GetAllRecentAvailableBookings+ H
(H I
)I J
;J K
Task 
< 
List 
< "
AdminBookingAllocation (
>( )
>) *:
.GetAdminBookingAllocationHistorybyBookingDates+ Y
(Y Z
DateTimeOffsetZ h
	StartDatei r
,r s
DateTimeOffset	t Ç
EndDate
É ä
,
ä ã
int
å è
page
ê î
,
î ï
int
ñ ô
size
ö û
)
û ü
;
ü †
} 
} ˘
åC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Contracts\Persistence\IAsyncRepository.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
	Contracts1 :
.: ;
Persistence; F
{ 
public		 

	interface		 
IAsyncRepository		 %
<		% &
T		& '
>		' (
where		) .
T		/ 0
:		1 2
class		3 8
{

 
Task 
< 
T 
> 
GetByIdAsync 
( 
int  
id! #
)# $
;$ %
Task 
< 
T 
> 
GetByIdAsync 
( 
Guid !
id" $
)$ %
;% &
Task 
< 
IReadOnlyList 
< 
T 
> 
> 
ListAllAsync +
(+ ,
), -
;- .
Task 
< 
T 
> 
AddAsync 
( 
T 
entity !
)! "
;" #
Task 
UpdateAsync 
( 
T 
entity !
)! "
;" #
Task 
DeleteAsync 
( 
T 
entity !
)! "
;" #
} 
} ’
îC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Contracts\Persistence\IIndividualLabRepository.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
	Contracts1 :
.: ;
Persistence; F
{		 
public

 

	interface

 $
IIndividualLabRepository

 -
:

. /
IAsyncRepository

0 @
<

@ A
IndividualLab

A N
>

N O
{ 
} 
} €
ëC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Contracts\Persistence\IIndividualRepository.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
	Contracts1 :
.: ;
Persistence; F
{		 
public

 

	interface

 !
IIndividualRepository

 *
:

+ ,
IAsyncRepository

- =
<

= >

Individual

> H
>

H I
{ 
Task 
< 
bool 
> 
DoesIndividualExist &
(& '
string' -
emailAddress. :
,: ;
string< B
mobileNumberC O
)O P
;P Q
Task 
< 

Individual 
> 2
&GetIndividualBookingByEmailAndMobileNo ?
(? @
string@ F
emailAddressG S
,S T
stringU [
mobileNumber\ h
)h i
;i j
} 
} ˝
èC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Contracts\Persistence\ILocationRepository.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
	Contracts1 :
.: ;
Persistence; F
{		 
public

 

	interface

 
ILocationRepository

 (
:

) *
IAsyncRepository

+ ;
<

; <
Location

< D
>

D E
{ 
Task 
< 
bool 
> 
DoesLocationExist $
($ %
int% (

locationId) 3
)3 4
;4 5
} 
} Œ
ÑC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Exceptions\BadRequestException.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1

Exceptions1 ;
{ 
public 

class 
BadRequestException $
:% & 
ApplicationException' ;
{ 
public 
BadRequestException "
(" #
string# )
message* 1
)1 2
:3 4
base5 9
(9 :
message: A
)A B
{ 	
}

 	
} 
} Ü
ÇC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Exceptions\NotFoundException.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1

Exceptions1 ;
{ 
public 

class 
NotFoundException "
:# $ 
ApplicationException% 9
{ 
public 
NotFoundException  
(  !
string! '
name( ,
,, -
object. 4
key5 8
)8 9
: 	
base
 
( 
$" 
{ 
name 
} 
$str 
{ 
key 
} 
$str ,
", -
)- .
{		 	
}

 	
} 
} é
ÑC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Exceptions\ValidationException.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1

Exceptions1 ;
{ 
public 

class 
ValidationException $
:% & 
ApplicationException' ;
{ 
public		 
List		 
<		 
string		 
>		 
ValdationErrors		 +
{		, -
get		. 1
;		1 2
set		3 6
;		6 7
}		8 9
public 
ValidationException "
(" #
ValidationResult# 3
validationResult4 D
)D E
{ 	
ValdationErrors 
= 
new !
List" &
<& '
string' -
>- .
(. /
)/ 0
;0 1
foreach 
( 
var 
validationError (
in) +
validationResult, <
.< =
Errors= C
)C D
{ 
ValdationErrors 
.  
Add  #
(# $
validationError$ 3
.3 4
ErrorMessage4 @
)@ A
;A B
} 
} 	
} 
} ∑	
∂C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Command\AllocateBookingSpace\AllocateBookingSpaceCommand.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
CommandI P
.P Q 
AllocateBookingSpaceQ e
{		 
public

 

class

 '
AllocateBookingSpaceCommand

 ,
:

- .
IRequest

/ 7
<

7 8/
#AllocateBookingSpaceCommandResponse

8 [
>

[ \
{ 
public 
int 
Capacity 
{ 
get !
;! "
set# &
;& '
}( )
public 
DateTimeOffset 
BookingDates *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
int 

LocationID 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} Â"
ΩC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Command\AllocateBookingSpace\AllocateBookingSpaceCommandHandler.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
CommandI P
.P Q 
AllocateBookingSpaceQ e
{ 
public 

class .
"AllocateBookingSpaceCommandHandler 3
:4 5
IRequestHandler6 E
<E F'
AllocateBookingSpaceCommandF a
,a b0
#AllocateBookingSpaceCommandResponse	c Ü
>
Ü á
{ 
private 
readonly -
!IAdminBookingAllocationRepository :-
!_adminBookingAllocationRepository; \
;\ ]
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
ILogger  
<  !.
"AllocateBookingSpaceCommandHandler! C
>C D
_loggerE L
;L M
private 
readonly 
ILocationRepository ,
_locationRepository- @
;@ A
public .
"AllocateBookingSpaceCommandHandler 1
(1 2-
!IAdminBookingAllocationRepository2 S,
 adminBookingAllocationRepositoryT t
,t u
IMapper 
mapper 
, 
ILogger #
<# $.
"AllocateBookingSpaceCommandHandler$ F
>F G
loggerH N
,N O
ILocationRepositoryP c
locationRepositoryd v
)v w
{ 	-
!_adminBookingAllocationRepository -
=. /,
 adminBookingAllocationRepository0 P
;P Q
_mapper 
= 
mapper 
; 
_logger 
= 
logger 
; 
_locationRepository 
=  !
locationRepository" 4
;4 5
} 	
public 
async 
Task 
< /
#AllocateBookingSpaceCommandResponse =
>= >
Handle? E
(E F'
AllocateBookingSpaceCommandF a
requestb i
,i j
CancellationTokenk |
cancellationToken	} é
)
é è
{ 	
try 
{   
var!! 
	validator!! 
=!! 
new!!  #)
AllocateBookingSpaceValidator!!$ A
(!!A B
_locationRepository!!B U
)!!U V
;!!V W
var"" 
validationResult"" $
=""% &
await""' ,
	validator""- 6
.""6 7
ValidateAsync""7 D
(""D E
request""E L
,""L M
cancellationToken""N _
)""_ `
;""` a
if$$ 
($$ 
validationResult$$ $
.$$$ %
Errors$$% +
.$$+ ,
Count$$, 1
>$$2 3
$num$$4 5
)$$5 6
throw%% 
new%% 
ValidationException%% 1
(%%1 2
validationResult%%2 B
)%%B C
;%%C D
var''  
allocateBookingSpace'' (
='') *
await''+ 0-
!_adminBookingAllocationRepository''1 R
.''R S
AddAsync''S [
(''[ \
_mapper''\ c
.''c d
Map''d g
<''g h"
AdminBookingAllocation''h ~
>''~ 
(	'' Ä
request
''Ä á
)
''á à
)
''à â
;
''â ä
return(( 
_mapper(( 
.(( 
Map(( "
<((" #/
#AllocateBookingSpaceCommandResponse((# F
>((F G
(((G H 
allocateBookingSpace((H \
)((\ ]
;((] ^
}** 
catch++ 
(++ 
	Exception++ 
ex++ 
)++  
{,, 
_logger-- 
.-- 
LogError--  
(--  !
ex--! #
,--# $
$"--% '
$str--' Z
{--Z [
nameof--[ a
(--a b
Handle--b h
)--h i
}--i j
"--j k
)--k l
;--l m
throw.. 
;.. 
}// 
}00 	
}11 
}22 °	
æC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Command\AllocateBookingSpace\AllocateBookingSpaceCommandResponse.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
CommandI P
.P Q 
AllocateBookingSpaceQ e
{		 
public

 

class

 /
#AllocateBookingSpaceCommandResponse

 4
:

5 6
BaseResponse

7 C
{ 
public /
#AllocateBookingSpaceCommandResponse 2
(2 3
)3 4
:5 6
base7 ;
(; <
)< =
{ 	
} 	
public 
int 
Capacity 
{ 
get !
;! "
set# &
;& '
}( )
public 
DateTimeOffset 
BookingDates *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
} 
} ©
∏C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Command\AllocateBookingSpace\AllocateBookingSpaceValidator.cs
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
$ %
Application

% 0
.

0 1
Features

1 9
.

9 :
Administrators

: H
.

H I
Command

I P
.

P Q 
AllocateBookingSpace

Q e
{ 
public 

class )
AllocateBookingSpaceValidator .
:/ 0
AbstractValidator1 B
<B C'
AllocateBookingSpaceCommandC ^
>^ _
{ 
public 
readonly 
ILocationRepository +
_locationRepository, ?
;? @
public )
AllocateBookingSpaceValidator ,
(, -
ILocationRepository- @
locationRepositoryA S
)S T
{ 	
_locationRepository 
=  !
locationRepository" 4
;4 5
RuleFor 
( 
p 
=> 
p 
. 
Capacity #
)# $
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
. 
GreaterThan 
( 
$num 
) 
; 
RuleFor 
( 
p 
=> 
p 
. 

LocationID %
)% &
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
. 
GreaterThan 
( 
$num 
) 
; 
RuleFor 
( 
p 
=> 
p 
. 
BookingDates '
)' (
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
.   
NotNull   
(   
)   
.!! 
GreaterThan!! 
(!! 
DateTimeOffset!! '
.!!' (
Now!!( +
.!!+ ,
AddDays!!, 3
(!!3 4
-!!4 5
$num!!5 6
)!!6 7
)!!7 8
;!!8 9
RuleFor## 
(## 
e## 
=>## 
e## 
)## 
.$$ 
	MustAsync$$ 
($$ 
DoesLocationExist$$ (
)$$( )
.%% 
WithMessage%% 
(%% 
$str%% 6
)%%6 7
;%%7 8
}'' 	
private)) 
async)) 
Task)) 
<)) 
bool)) 
>))  
DoesLocationExist))! 2
())2 3'
AllocateBookingSpaceCommand))3 N
e))O P
,))P Q
CancellationToken))R c
token))d i
)))i j
{** 	
return++ 
await++ 
_locationRepository++ ,
.++, -
DoesLocationExist++- >
(++> ?
e++? @
.++@ A

LocationID++A K
)++K L
;++L M
},, 	
}-- 
}.. ˆ	
∑C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Queries\GetAvailableBookingDetails\AvailableBookingListVm.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
QueriesI P
.P Q&
GetAvailableBookingDetailsQ k
{		 
public

 

class

 "
AvailableBookingListVm

 '
{ 
public 
int 
Capacity 
{ 
get !
;! "
set# &
;& '
}( )
public 
int 
SpaceAllocated !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTimeOffset 
BookingDates *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public #
AvailableLocationListVm &
Location' /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
} 
} í
¿C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Queries\GetAvailableBookingDetails\GetAvailableBookingDetailsQuery.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
QueriesI P
.P Q&
GetAvailableBookingDetailsQ k
{		 
public

 

class

 +
GetAvailableBookingDetailsQuery

 0
:

1 2
IRequest

3 ;
<

; <
List

< @
<

@ A"
AvailableBookingListVm

A W
>

W X
>

X Y
{ 
} 
} ò
«C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Queries\GetAvailableBookingDetails\GetAvailableBookingDetailsQueryHandler.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
QueriesI P
.P Q&
GetAvailableBookingDetailsQ k
{ 
public 

class 2
&GetAvailableBookingDetailsQueryHandler 7
:8 9
IRequestHandler: I
<I J+
GetAvailableBookingDetailsQueryJ i
,i j
Listk o
<o p#
AvailableBookingListVm	p Ü
>
Ü á
>
á à
{ 
private 
readonly -
!IAdminBookingAllocationRepository :-
!_adminBookingAllocationRepository; \
;\ ]
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
ILogger  
<  !2
&GetAvailableBookingDetailsQueryHandler! G
>G H
_loggerI P
;P Q
public 2
&GetAvailableBookingDetailsQueryHandler 5
(5 6-
!IAdminBookingAllocationRepository6 W,
 adminBookingAllocationRepositoryX x
,x y
IMapper 
mapper 
, 
ILogger #
<# $2
&GetAvailableBookingDetailsQueryHandler$ J
>J K
loggerL R
)R S
{ 	-
!_adminBookingAllocationRepository -
=. /,
 adminBookingAllocationRepository0 P
;P Q
_mapper 
= 
mapper 
; 
_logger 
= 
logger 
; 
} 	
public 
async 
Task 
< 
List 
< "
AvailableBookingListVm 5
>5 6
>6 7
Handle8 >
(> ?+
GetAvailableBookingDetailsQuery? ^
request_ f
,f g
CancellationTokenh y
cancellationToken	z ã
)
ã å
{ 	
try 
{ 
var 
allBookings 
=  !
await" '-
!_adminBookingAllocationRepository( I
.I J)
GetAllRecentAvailableBookingsJ g
(g h
)h i
;i j
return 
_mapper 
. 
Map "
<" #
List# '
<' ("
AvailableBookingListVm( >
>> ?
>? @
(@ A
allBookingsA L
)L M
;M N
}   
catch!! 
(!! 
	Exception!! 
ex!! 
)!!  
{"" 
_logger## 
.## 
LogError##  
(##  !
ex##! #
,### $
$"##% '
$str##' ^
{##^ _
nameof##_ e
(##e f
Handle##f l
)##l m
}##m n
"##n o
)##o p
;##p q
throw$$ 
;$$ 
}%% 
}&& 	
}'' 
}(( ˇ
≤C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Queries\GetAvailableBookingDetails\LocationDetailsVM.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
QueriesI P
.P Q&
GetAvailableBookingDetailsQ k
{ 
public		 

class		 
LocationDetailsVM		 "
{

 
public 
string 
LocationName "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
} ∏
ØC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Queries\GetBookingsReports\BookingsReportsListsVm.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
QueriesI P
.P Q
GetBookingsReportsQ c
{ 
public		 

class		 "
BookingsReportsListsVm		 '
{

 
public 
int 
Capacity 
{ 
get !
;! "
set# &
;& '
}( )
public 
int 
SpaceAllocated !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTimeOffset 
BookingDates *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
LocationListsVm 
Location '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
List 
< 
IndividualListsVm %
>% &
Individuals' 2
{3 4
get5 8
;8 9
set: =
;= >
}? @
} 
}   ‰

∞C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Queries\GetBookingsReports\GetBookingsReportsQuery.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
QueriesI P
.P Q
GetBookingsReportsQ c
{		 
public

 

class

 #
GetBookingsReportsQuery

 (
:

) *
IRequest

+ 3
<

3 4
List

4 8
<

8 9"
BookingsReportsListsVm

9 O
>

O P
>

P Q
{ 
public 
DateTimeOffset 
	StartDate '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
DateTimeOffset 
EndDate %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
int 
Page 
{ 
get 
; 
set "
;" #
}$ %
public 
int 
Size 
{ 
get 
; 
set "
;" #
}$ %
}   
}!! É"
∑C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Queries\GetBookingsReports\GetBookingsReportsQueryHandler.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
QueriesI P
.P Q
GetBookingsReportsQ c
{ 
public 

class *
GetBookingsReportsQueryHandler /
:0 1
IRequestHandler2 A
<A B#
GetBookingsReportsQueryB Y
,Y Z
List[ _
<_ `"
BookingsReportsListsVm` v
>v w
>w x
{ 
private 
readonly -
!IAdminBookingAllocationRepository :-
!_adminBookingAllocationRepository; \
;\ ]
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
ILogger  
<  !*
GetBookingsReportsQueryHandler! ?
>? @
_loggerA H
;H I
public *
GetBookingsReportsQueryHandler -
(- .-
!IAdminBookingAllocationRepository. O,
 adminBookingAllocationRepositoryP p
,p q
IMapper 
mapper 
, 
ILogger #
<# $*
GetBookingsReportsQueryHandler$ B
>B C
loggerD J
)J K
{ 	-
!_adminBookingAllocationRepository -
=. /,
 adminBookingAllocationRepository0 P
;P Q
_mapper 
= 
mapper 
; 
_logger 
= 
logger 
; 
} 	
public 
async 
Task 
< 
List 
< "
BookingsReportsListsVm 5
>5 6
>6 7
Handle8 >
(> ?#
GetBookingsReportsQuery? V
requestW ^
,^ _
CancellationToken` q
cancellationToken	r É
)
É Ñ
{ 	
try 
{   
var!! 
	validator!! 
=!! 
new!!  #(
GetBookingsReportsValidators!!$ @
(!!@ A
)!!A B
;!!B C
var"" 
validationResult"" $
=""% &
await""' ,
	validator""- 6
.""6 7
ValidateAsync""7 D
(""D E
request""E L
,""L M
cancellationToken""N _
)""_ `
;""` a
if$$ 
($$ 
validationResult$$ $
.$$$ %
Errors$$% +
.$$+ ,
Count$$, 1
>$$2 3
$num$$4 5
)$$5 6
throw%% 
new%% 
ValidationException%% 1
(%%1 2
validationResult%%2 B
)%%B C
;%%C D
var''  
bookingsReportsLists'' (
='') *
await''+ 0-
!_adminBookingAllocationRepository''1 R
.''R S;
.GetAdminBookingAllocationHistorybyBookingDates	''S Å
(
''Å Ç
request
''Ç â
.
''â ä
	StartDate
''ä ì
,
''ì î
request
''ï ú
.
''ú ù
EndDate
''ù §
,
''§ •
request
''¶ ≠
.
''≠ Æ
Page
''Æ ≤
,
''≤ ≥
request
''¥ ª
.
''ª º
Size
''º ¿
)
''¿ ¡
;
''¡ ¬
return(( 
_mapper(( 
.(( 
Map(( "
<((" #
List((# '
<((' ("
BookingsReportsListsVm((( >
>((> ?
>((? @
(((@ A 
bookingsReportsLists((A U
)((U V
;((V W
})) 
catch** 
(** 
	Exception** 
ex** 
)**  
{++ 
_logger,, 
.,, 
LogError,,  
(,,  !
ex,,! #
,,,# $
$",,% '
$str,,' V
{,,V W
nameof,,W ]
(,,] ^
Handle,,^ d
),,d e
},,e f
",,f g
),,g h
;,,h i
throw-- 
;-- 
}.. 
}// 	
}00 
}11 
µC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Queries\GetBookingsReports\GetBookingsReportsValidators.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
QueriesI P
.P Q
GetBookingsReportsQ c
{		 
public

 

class

 (
GetBookingsReportsValidators

 -
:

. /
AbstractValidator

1 B
<

B C#
GetBookingsReportsQuery

C Z
>

Z [
{ 
public (
GetBookingsReportsValidators +
(+ ,
), -
{ 	
RuleFor 
( 
p 
=> 
p 
. 
	StartDate $
)$ %
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
; 
RuleFor 
( 
p 
=> 
p 
. 
EndDate "
)" #
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
; 
RuleFor 
( 
p 
=> 
p 
. 
Size 
)  
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
. 
GreaterThan 
( 
$num 
) 
. 
WithMessage '
(' (
$str( V
)V W
;W X
RuleFor 
( 
p 
=> 
p 
. 
Page 
)  
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
. 
GreaterThan 
( 
$num 
) 
. 
WithMessage '
(' (
$str( V
)V W
;W X
}   	
}!! 
}"" ≠
¨C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Queries\GetBookingsReports\IndividualLabListVm.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
QueriesI P
.P Q
GetBookingsReportsQ c
{ 
public		 

class		 
IndividualLabListVm		 $
{

 
public 
string 
TestType 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
TestOutCome !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
bool 
TestCompleted !
{" #
get$ '
;' (
set) ,
;, -
}. /
} 
} «
™C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Queries\GetBookingsReports\IndividualListsVm.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
QueriesI P
.P Q
GetBookingsReportsQ c
{ 
public		 

class		 
IndividualListsVm		 "
{

 
public 
string 
IndividualFirstName )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
string 
IndividualLastName (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
string "
IndividualEmailAddress ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
string "
IndividualMobileNumber ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
bool #
IndividualBookingStatus +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
IndividualLabListVm "
IndividualLab# 0
{1 2
get3 6
;6 7
set8 ;
;; <
}= >
} 
} Î
®C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Administrators\Queries\GetBookingsReports\LocationListsVm.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Administrators: H
.H I
QueriesI P
.P Q
GetBookingsReportsQ c
{ 
public		 

class		 
LocationListsVm		  
{

 
public 
string 
LocationName "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
} õ	
™C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\IndividualLabs\Command\SetTestOutcome\SetTestOutcomeCommand.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
IndividualLabs: H
.H I
CommandI P
.P Q
SetTestOutcomeQ _
{ 
public 

class !
SetTestOutcomeCommand &
:' (
IRequest) 1
<1 2)
SetTestOutcomeCommandResponse2 O
>O P
{ 
public

 
int

 
IndividualLabId

 "
{

# $
get

% (
;

( )
set

* -
;

- .
}

/ 0
public 
string 
TestOutCome !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
bool 
TestCompleted !
{" #
get$ '
;' (
set) ,
;, -
}. /
} 
} √"
±C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\IndividualLabs\Command\SetTestOutcome\SetTestOutcomeCommandHandler.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
IndividualLabs: H
.H I
CommandI P
.P Q
SetTestOutcomeQ _
{ 
public 

class (
SetTestOutcomeCommandHandler -
:. /
IRequestHandler0 ?
<? @!
SetTestOutcomeCommand@ U
,U V)
SetTestOutcomeCommandResponseW t
>t u
{ 
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
ILogger  
<  !(
SetTestOutcomeCommandHandler! =
>= >
_logger? F
;F G
private 
readonly $
IIndividualLabRepository 1$
_individualLabRepository2 J
;J K
public (
SetTestOutcomeCommandHandler +
(+ ,
IMapper, 3
mapper4 :
,: ;
ILogger< C
<C D(
SetTestOutcomeCommandHandlerD `
>` a
loggerb h
,h i$
IIndividualLabRepository $#
individualLabRepository% <
)< =
{ 	
_mapper 
= 
mapper 
; 
_logger 
= 
logger 
; $
_individualLabRepository $
=% &#
individualLabRepository' >
;> ?
} 	
public 
async 
Task 
< )
SetTestOutcomeCommandResponse 7
>7 8
Handle9 ?
(? @!
SetTestOutcomeCommand@ U
requestV ]
,] ^
CancellationToken_ p
cancellationToken	q Ç
)
Ç É
{ 	
try 
{   
var!! 
	validator!! 
=!! 
new!!  ##
SetTestOutcomeValidator!!$ ;
(!!; <
)!!< =
;!!= >
var"" 
validationResult"" $
=""% &
await""' ,
	validator""- 6
.""6 7
ValidateAsync""7 D
(""D E
request""E L
,""L M
cancellationToken""N _
)""_ `
;""` a
if$$ 
($$ 
validationResult$$ $
.$$$ %
Errors$$% +
.$$+ ,
Count$$, 1
>$$2 3
$num$$4 5
)$$5 6
throw%% 
new%% 
ValidationException%% 1
(%%1 2
validationResult%%2 B
)%%B C
;%%C D
var'' $
getIndividualLabsRecords'' ,
=''- .
await''/ 4$
_individualLabRepository''5 M
.''M N
GetByIdAsync''N Z
(''Z [
request''[ b
.''b c
IndividualLabId''c r
)''r s
;''s t
_mapper(( 
.(( 
Map(( 
((( 
request(( #
,((# $$
getIndividualLabsRecords((% =
,((= >
typeof((? E
(((E F!
SetTestOutcomeCommand((F [
)(([ \
,((\ ]
typeof((^ d
(((d e
IndividualLab((e r
)((r s
)((s t
;((t u
await** $
_individualLabRepository** .
.**. /
UpdateAsync**/ :
(**: ;$
getIndividualLabsRecords**; S
)**S T
;**T U
return++ 
_mapper++ 
.++ 
Map++ "
<++" #)
SetTestOutcomeCommandResponse++# @
>++@ A
(++A B$
getIndividualLabsRecords++B Z
)++Z [
;++[ \
},, 
catch-- 
(-- 
	Exception-- 
ex-- 
)--  
{.. 
_logger// 
.// 
LogError//  
(//  !
ex//! #
,//# $
$"//% '
$str//' T
{//T U
nameof//U [
(//[ \
Handle//\ b
)//b c
}//c d
"//d e
)//e f
;//f g
throw00 
;00 
}11 
}22 	
}33 
}44 Ä	
≤C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\IndividualLabs\Command\SetTestOutcome\SetTestOutcomeCommandResponse.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
IndividualLabs: H
.H I
CommandI P
.P Q
SetTestOutcomeQ _
{ 
public 

class )
SetTestOutcomeCommandResponse .
:/ 0
BaseResponse1 =
{ 
public )
SetTestOutcomeCommandResponse ,
(, -
)- .
:/ 0
base1 5
(5 6
)6 7
{ 	
}

 	
public 
string 
TestOutCome !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
bool 
TestCompleted !
{" #
get$ '
;' (
set) ,
;, -
}. /
} 
} ¶
¨C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\IndividualLabs\Command\SetTestOutcome\SetTestOutcomeValidator.cs
	namespace		 	
COVID_19PCR		
 
.		 
TestManagement		 $
.		$ %
Application		% 0
.		0 1
Features		1 9
.		9 :
IndividualLabs		: H
.		H I
Command		I P
.		P Q
SetTestOutcome		Q _
{

 
public 

class #
SetTestOutcomeValidator (
:) *
AbstractValidator+ <
<< =!
SetTestOutcomeCommand= R
>R S
{ 
public #
SetTestOutcomeValidator &
(& '
)' (
{ 	
RuleFor 
( 
p 
=> 
p 
. 
IndividualLabId *
)* +
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
. 
GreaterThan 
( 
$num 
) 
; 
RuleFor 
( 
p 
=> 
p 
. 
TestCompleted (
)( )
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
; 
RuleFor 
( 
p 
=> 
p 
. 
TestOutCome &
)& '
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
; 
RuleFor 
( 
e 
=> 
e 
) 
. 
	MustAsync 
( "
IsValidTestOutcomeType -
)- .
. 
WithMessage 
( 
$str L
)L M
;M N
} 	
private!! 
Task!! 
<!! 
bool!! 
>!! "
IsValidTestOutcomeType!! 1
(!!1 2!
SetTestOutcomeCommand!!2 G
e!!H I
,!!I J
CancellationToken!!K \
token!!] b
)!!b c
{"" 	
var## 
isValid## 
=## 
TestOutcomeData## )
.##) *
TestOutcomeType##* 9
.##9 :
Contains##: B
(##B C
e##C D
.##D E
TestOutCome##E P
.##P Q
ToLower##Q X
(##X Y
)##Y Z
)##Z [
;##[ \
return$$ 
Task$$ 
.$$ 

FromResult$$ "
($$" #
isValid$$# *
)$$* +
;$$+ ,
}&& 	
}'' 
}(( ø
§C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\IndividualLabs\Command\SetTestOutcome\TestOutcomeData.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
IndividualLabs: H
.H I
CommandI P
.P Q
SetTestOutcomeQ _
{ 
public		 

class		 
TestOutcomeData		  
{

 
public 
static 
readonly 
string %
[% &
]& '
TestOutcomeType( 7
=8 9
{: ;
$str< F
,F G
$strH R
}S T
;T U
} 
} ≈
•C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Command\BookCovidTest\BookCovidTestCommand.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
CommandF M
.M N
BookCovidTestN [
{ 
public 

class  
BookCovidTestCommand %
:& '
IRequest( 0
<0 1(
BookCovidTestCommandResponse1 M
>M N
{ 
public 
string 
IndividualFirstName )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
string 
IndividualLastName (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
string "
IndividualEmailAddress ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
string "
IndividualMobileNumber ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
DateTimeOffset 
BookingDate )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
int 

LocationID 
{ 
get  #
;# $
set% (
;( )
}* +
public## !
IndividualLabsRequest## $
IndividualLab##% 2
{##3 4
get##5 8
;##8 9
set##: =
;##= >
}##? @
}%% 
}&& ‘2
¨C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Command\BookCovidTest\BookCovidTestCommandHandler.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
CommandF M
.M N
BookCovidTestN [
{ 
public 

class '
BookCovidTestCommandHandler ,
:- .
IRequestHandler/ >
<> ? 
BookCovidTestCommand? S
,S T(
BookCovidTestCommandResponseU q
>q r
{ 
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
ILogger  
<  !'
BookCovidTestCommandHandler! <
>< =
_logger> E
;E F
private 
readonly 
ILocationRepository ,
_locationRepository- @
;@ A
private 
readonly !
IIndividualRepository .!
_individualRepository/ D
;D E
private 
readonly -
!IAdminBookingAllocationRepository :-
!_adminBookingAllocationRepository; \
;\ ]
public '
BookCovidTestCommandHandler *
(* +
IMapper+ 2
mapper3 9
,9 :
ILogger; B
<B C'
BookCovidTestCommandHandlerC ^
>^ _
logger` f
,f g
ILocationRepositoryh {
locationRepository	| é
,
é è!
IIndividualRepository ! 
individualRepository" 6
,6 7-
!IAdminBookingAllocationRepository8 Y,
 adminBookingAllocationRepositoryZ z
)z {
{ 	
_mapper 
= 
mapper 
; 
_logger 
= 
logger 
; 
_locationRepository 
=  !
locationRepository" 4
;4 5!
_individualRepository !
=" # 
individualRepository$ 8
;8 9-
!_adminBookingAllocationRepository -
=. /,
 adminBookingAllocationRepository0 P
;P Q
}   	
public!! 
async!! 
Task!! 
<!! (
BookCovidTestCommandResponse!! 6
>!!6 7
Handle!!8 >
(!!> ? 
BookCovidTestCommand!!? S
request!!T [
,!![ \
CancellationToken!!] n
cancellationToken	!!o Ä
)
!!Ä Å
{"" 	
try## 
{$$ 
var%% 
	validator%% 
=%% 
new%%  #"
BookCovidTestValidator%%$ :
(%%: ;
_locationRepository%%; N
,%%N O!
_individualRepository%%P e
)%%e f
;%%f g
var&& 
validationResult&& $
=&&% &
await&&' ,
	validator&&- 6
.&&6 7
ValidateAsync&&7 D
(&&D E
request&&E L
,&&L M
cancellationToken&&N _
)&&_ `
;&&` a
if(( 
((( 
validationResult(( $
.(($ %
Errors((% +
.((+ ,
Count((, 1
>((2 3
$num((4 5
)((5 6
throw)) 
new)) 
ValidationException)) 1
())1 2
validationResult))2 B
)))B C
;))C D
var++ 
getAdminProfiling++ %
=++& '
await++( --
!_adminBookingAllocationRepository++. O
.++O P@
3GetAdminBookingAllocationByLocationIdandBookingDate	++P É
(
++É Ñ
request
++Ñ ã
.
++ã å

LocationID
++å ñ
,
++ñ ó
request
++ò ü
.
++ü †
BookingDate
++† ´
)
++´ ¨
;
++¨ ≠
if,, 
(,, 
getAdminProfiling,, %
==,,& (
null,,) -
),,- .
{-- 
throw.. 
new.. 
NotFoundException.. /
(../ 0
nameof..0 6
(..6 7"
AdminBookingAllocation..7 M
)..M N
,..N O
request..P W
...W X

LocationID..X b
)..b c
;..c d
}00 
if11 
(11 
getAdminProfiling11 %
.11% &
SpaceAllocated11& 4
>=115 7
getAdminProfiling118 I
.11I J
Capacity11J R
)11R S
{22 
throw33 
new33 
BadRequestException33 1
(331 2
$str332 g
)33g h
;33h i
}44 
var66 
individualData66 "
=66# $
_mapper66% ,
.66, -
Map66- 0
<660 1

Individual661 ;
>66; <
(66< =
request66= D
)66D E
;66E F
individualData77 
.77 $
AdminBookingAllocationId77 7
=778 9
getAdminProfiling77: K
.77K L$
AdminBookingAllocationId77L d
;77d e
var99 #
insertIndividualDetails99 +
=99, -
await99. 3!
_individualRepository994 I
.99I J
AddAsync99J R
(99R S
individualData99S a
)99a b
;99b c
getAdminProfiling<< !
.<<! "
SpaceAllocated<<" 0
+=<<1 3
$num<<4 5
;<<5 6
await== -
!_adminBookingAllocationRepository== 7
.==7 8
UpdateAsync==8 C
(==C D
getAdminProfiling==D U
)==U V
;==V W
return?? 
_mapper?? 
.?? 
Map?? "
<??" #(
BookCovidTestCommandResponse??# ?
>??? @
(??@ A#
insertIndividualDetails??A X
)??X Y
;??Y Z
}@@ 
catchAA 
(AA 
	ExceptionAA 
exAA 
)AA  
{BB 
_loggerCC 
.CC 
LogErrorCC  
(CC  !
exCC! #
,CC# $
$"CC% '
$strCC' S
{CCS T
nameofCCT Z
(CCZ [
HandleCC[ a
)CCa b
}CCb c
"CCc d
)CCd e
;CCe f
throwDD 
;DD 
}EE 
}GG 	
}HH 
}II ˘
≠C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Command\BookCovidTest\BookCovidTestCommandResponse.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
CommandF M
.M N
BookCovidTestN [
{		 
public

 

class

 (
BookCovidTestCommandResponse

 -
:

. /
BaseResponse

0 <
{ 
public (
BookCovidTestCommandResponse +
(+ ,
), -
:. /
base0 4
(4 5
)5 6
{ 	
} 	
public 
string 
IndividualFirstName )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
string 
IndividualLastName (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
string "
IndividualEmailAddress ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public   
string   "
IndividualMobileNumber   ,
{  - .
get  / 2
;  2 3
set  4 7
;  7 8
}  9 :
public$$ 
DateTime$$ 
BookingDate$$ #
{$$$ %
get$$& )
;$$) *
set$$+ .
;$$. /
}$$0 1
}%% 
}&& ∫8
ßC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Command\BookCovidTest\BookCovidTestValidator.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
CommandF M
.M N
BookCovidTestN [
{ 
public 

class "
BookCovidTestValidator '
:( )
AbstractValidator* ;
<; < 
BookCovidTestCommand< P
>P Q
{ 
private 
readonly 
ILocationRepository ,
_locationRepository- @
;@ A
private 
readonly !
IIndividualRepository .!
_individualRepository/ D
;D E
public "
BookCovidTestValidator %
(% &
ILocationRepository& 9
locationRepository: L
,L M!
IIndividualRepositoryN c 
individualRepositoryd x
)x y
{ 	
_locationRepository 
=  !
locationRepository" 4
;4 5!
_individualRepository !
=" # 
individualRepository$ 8
;8 9
RuleFor 
( 
p 
=> 
p 
. 

LocationID %
)% &
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
. 
GreaterThan 
( 
$num 
) 
; 
RuleFor 
( 
p 
=> 
p 
. "
IndividualEmailAddress 1
)1 2
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
. 
EmailAddress 
( 
) 
; 
RuleFor   
(   
p   
=>   
p   
.   
IndividualFirstName   .
)  . /
.!! 
NotEmpty!! 
(!! 
)!! 
.!! 
WithMessage!! #
(!!# $
$str!!$ A
)!!A B
."" 
NotNull"" 
("" 
)"" 
.## 
MaximumLength## 
(## 
$num## 
)## 
;##  
RuleFor%% 
(%% 
p%% 
=>%% 
p%% 
.%% 
IndividualLastName%% -
)%%- .
.&& 
NotEmpty&& 
(&& 
)&& 
.&& 
WithMessage&& #
(&&# $
$str&&$ A
)&&A B
.'' 
NotNull'' 
('' 
)'' 
.(( 
MaximumLength(( 
((( 
$num(( 
)(( 
;((  
RuleFor** 
(** 
p** 
=>** 
p** 
.** "
IndividualMobileNumber** 1
)**1 2
.++ 
NotEmpty++ 
(++ 
)++ 
.++ 
WithMessage++ #
(++# $
$str++$ A
)++A B
.,, 
NotNull,, 
(,, 
),, 
.-- 
MaximumLength-- 
(-- 
$num-- 
)-- 
;-- 
RuleFor// 
(// 
p// 
=>// 
p// 
.// 
BookingDate// &
)//& '
.00 
NotEmpty00 
(00 
)00 
.00 
WithMessage00 #
(00# $
$str00$ A
)00A B
.11 
NotNull11 
(11 
)11 
.22 
GreaterThan22 
(22 
DateTimeOffset22 '
.22' (
Now22( +
.22+ ,
AddDays22, 3
(223 4
-224 5
$num225 6
)226 7
)227 8
;228 9
RuleFor44 
(44 
e44 
=>44 
e44 
)44 
.55 
	MustAsync55 
(55 
DoesLocationExist55 (
)55( )
.66 
WithMessage66 
(66 
$str66 6
)666 7
;667 8
RuleFor88 
(88 
e88 
=>88 
e88 
)88 
.99 
	MustAsync99 
(99 
DoesIndividualExist99 *
)99* +
.:: 
WithMessage:: 
(:: 
$str:: @
)::@ A
;::A B
RuleFor<< 
(<< 
e<< 
=><< 
e<< 
)<< 
.== 
	MustAsync== 
(== 
IsValidTestType== &
)==& '
.>> 
WithMessage>> 
(>> 
$str>> I
)>>I J
;>>J K
}@@ 	
privateBB 
asyncBB 
TaskBB 
<BB 
boolBB 
>BB  
DoesLocationExistBB! 2
(BB2 3 
BookCovidTestCommandBB3 G
eBBH I
,BBI J
CancellationTokenBBK \
tokenBB] b
)BBb c
{CC 	
returnDD 
awaitDD 
_locationRepositoryDD ,
.DD, -
DoesLocationExistDD- >
(DD> ?
eDD? @
.DD@ A

LocationIDDDA K
)DDK L
;DDL M
}EE 	
privateGG 
asyncGG 
TaskGG 
<GG 
boolGG 
>GG  
DoesIndividualExistGG! 4
(GG4 5 
BookCovidTestCommandGG5 I
eGGJ K
,GGK L
CancellationTokenGGM ^
tokenGG_ d
)GGd e
{HH 	
returnII 
!II 
(II 
awaitII !
_individualRepositoryII 0
.II0 1
DoesIndividualExistII1 D
(IID E
eIIE F
.IIF G"
IndividualEmailAddressIIG ]
,II] ^
eII_ `
.II` a"
IndividualMobileNumberIIa w
)IIw x
)IIx y
;IIy z
}JJ 	
privateLL 
TaskLL 
<LL 
boolLL 
>LL 
IsValidTestTypeLL *
(LL* + 
BookCovidTestCommandLL+ ?
eLL@ A
,LLA B
CancellationTokenLLC T
tokenLLU Z
)LLZ [
{MM 	
varNN 
isValidNN 
=NN 
TestTypeDataNN &
.NN& '
TestTypeNN' /
.NN/ 0
ContainsNN0 8
(NN8 9
eNN9 :
.NN: ;
IndividualLabNN; H
.NNH I
TestTypeNNI Q
.NNQ R
ToLowerNNR Y
(NNY Z
)NNZ [
)NN[ \
;NN\ ]
returnOO 
TaskOO 
.OO 

FromResultOO "
(OO" #
isValidOO# *
)OO* +
;OO+ ,
}QQ 	
}RR 
}SS „
¶C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Command\BookCovidTest\IndividualLabsRequest.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
CommandF M
.M N
BookCovidTestN [
{ 
public 

class !
IndividualLabsRequest &
{ 
public		 
string		 
TestType		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
}

 
} ™
ùC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Command\BookCovidTest\TestTypeData.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
CommandF M
.M N
BookCovidTestN [
{ 
public		 

class		 
TestTypeData		 
{

 
public 
static 
readonly 
string %
[% &
]& '
TestType( 0
=1 2
{3 4
$str5 >
,> ?
$str@ K
}L M
;M N
} 
} æ	
´C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Command\CancelBookedTest\CancelBookedTestCommand.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
CommandF M
.M N
CancelBookedTestN ^
{		 
public

 

class

 #
CancelBookedTestCommand

 (
:

) *
IRequest

+ 3
<

3 4+
CancelBookedTestCommandResponse

4 S
>

S T
{ 
public 
string "
IndividualEmailAddress ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
string "
IndividualMobileNumber ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
bool #
IndividualBookingStatus +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
} 
} º#
≤C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Command\CancelBookedTest\CancelBookedTestCommandHandler.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
CommandF M
.M N
CancelBookedTestN ^
{ 
public 

class *
CancelBookedTestCommandHandler /
:0 1
IRequestHandler2 A
<A B#
CancelBookedTestCommandB Y
,Y Z+
CancelBookedTestCommandResponse[ z
>z {
{ 
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
ILogger  
<  !*
CancelBookedTestCommandHandler! ?
>? @
_loggerA H
;H I
private 
readonly !
IIndividualRepository .!
_individualRepository/ D
;D E
public *
CancelBookedTestCommandHandler -
(- .
IMapper. 5
mapper6 <
,< =
ILogger> E
<E F*
CancelBookedTestCommandHandlerF d
>d e
loggerf l
,l m!
IIndividualRepository ! 
individualRepository" 6
)6 7
{ 	
_mapper 
= 
mapper 
; 
_logger 
= 
logger 
; !
_individualRepository !
=" # 
individualRepository$ 8
;8 9
} 	
public 
async 
Task 
< +
CancelBookedTestCommandResponse 9
>9 :
Handle; A
(A B#
CancelBookedTestCommandB Y
requestZ a
,a b
CancellationTokenc t
cancellationToken	u Ü
)
Ü á
{ 	
try 
{   
var!! 
	validator!! 
=!! 
new!!  #%
CancelBookedTestValidator!!$ =
(!!= >!
_individualRepository!!> S
)!!S T
;!!T U
var"" 
validationResult"" $
=""% &
await""' ,
	validator""- 6
.""6 7
ValidateAsync""7 D
(""D E
request""E L
,""L M
cancellationToken""N _
)""_ `
;""` a
if$$ 
($$ 
validationResult$$ $
.$$$ %
Errors$$% +
.$$+ ,
Count$$, 1
>$$2 3
$num$$4 5
)$$5 6
throw%% 
new%% 
ValidationException%% 1
(%%1 2
validationResult%%2 B
)%%B C
;%%C D
var'' 
individualRecord'' $
=''% &
await''' ,!
_individualRepository''- B
.''B C2
&GetIndividualBookingByEmailAndMobileNo''C i
(''i j
request''j q
.''q r#
IndividualEmailAddress	''r à
,
''à â
request(( 
.(( "
IndividualMobileNumber(( 2
)((2 3
;((3 4
_mapper)) 
.)) 
Map)) 
()) 
request)) #
,))# $
individualRecord))% 5
,))5 6
typeof))7 =
())= >#
CancelBookedTestCommand))> U
)))U V
,))V W
typeof))X ^
())^ _

Individual))_ i
)))i j
)))j k
;))k l
await** !
_individualRepository** +
.**+ ,
UpdateAsync**, 7
(**7 8
individualRecord**8 H
)**H I
;**I J
return,, 
_mapper,, 
.,, 
Map,, "
<,," #+
CancelBookedTestCommandResponse,,# B
>,,B C
(,,C D
individualRecord,,D T
),,T U
;,,U V
}-- 
catch.. 
(.. 
	Exception.. 
ex.. 
)..  
{// 
_logger00 
.00 
LogError00  
(00  !
ex00! #
,00# $
$"00% '
$str00' V
{00V W
nameof00W ]
(00] ^
Handle00^ d
)00d e
}00e f
"00f g
)00g h
;00h i
throw11 
;11 
}22 
}33 	
}44 
}55 ﬁ
≥C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Command\CancelBookedTest\CancelBookedTestCommandResponse.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
CommandF M
.M N
CancelBookedTestN ^
{		 
public

 

class

 +
CancelBookedTestCommandResponse

 0
:

1 2
BaseResponse

3 ?
{ 
public 
string "
IndividualEmailAddress ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
string "
IndividualMobileNumber ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
} 
} è
≠C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Command\CancelBookedTest\CancelBookedTestValidator.cs
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
$ %
Application

% 0
.

0 1
Features

1 9
.

9 :
Individuals

: E
.

E F
Command

F M
.

M N
CancelBookedTest

N ^
{ 
public 

class %
CancelBookedTestValidator *
:+ ,
AbstractValidator- >
<> ?#
CancelBookedTestCommand? V
>V W
{ 
private 
readonly !
IIndividualRepository .!
_individualRepository/ D
;D E
public %
CancelBookedTestValidator (
(( )!
IIndividualRepository) > 
individualRepository? S
)S T
{ 	!
_individualRepository !
=" # 
individualRepository$ 8
;8 9
RuleFor 
( 
p 
=> 
p 
. "
IndividualEmailAddress 1
)1 2
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
. 
EmailAddress 
( 
) 
; 
RuleFor 
( 
p 
=> 
p 
. "
IndividualMobileNumber 1
)1 2
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
. 
MaximumLength 
( 
$num 
) 
; 
RuleFor 
( 
p 
=> 
p 
. #
IndividualBookingStatus 2
)2 3
. 
NotNull 
( 
) 
; 
RuleFor!! 
(!! 
e!! 
=>!! 
e!! 
)!! 
."" 
	MustAsync"" 
("" 
DoesIndividualExist"" *
)""* +
.## 
WithMessage## 
(## 
$str## s
)##s t
;##t u
}$$ 	
private&& 
async&& 
Task&& 
<&& 
bool&& 
>&&  
DoesIndividualExist&&! 4
(&&4 5#
CancelBookedTestCommand&&5 L
e&&M N
,&&N O
CancellationToken&&P a
token&&b g
)&&g h
{'' 	
return(( 
await(( !
_individualRepository(( .
.((. /
DoesIndividualExist((/ B
(((B C
e((C D
.((D E"
IndividualEmailAddress((E [
,(([ \
e((] ^
.((^ _"
IndividualMobileNumber((_ u
)((u v
;((v w
})) 	
}** 
}++ “
œC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Queries\GetIndividualInfoByMobileNoAndEmail\GetIndividualInfoByMobileNoAndEmailQuery.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
QueriesF M
.M N/
#GetIndividualInfoByMobileNoAndEmailN q
{		 
public

 

class

 4
(GetIndividualInfoByMobileNoAndEmailQuery

 9
:

: ;
IRequest

< D
<

D E 
IndividualInfoListVm

E Y
>

Y Z
{ 
public 
string "
IndividualEmailAddress ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
string "
IndividualMobileNumber ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
} 
} … 
÷C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Queries\GetIndividualInfoByMobileNoAndEmail\GetIndividualInfoByMobileNoAndEmailQueryHandler.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
QueriesF M
.M N/
#GetIndividualInfoByMobileNoAndEmailN q
{ 
public 

class ;
/GetIndividualInfoByMobileNoAndEmailQueryHandler @
:A B
IRequestHandlerC R
<R S4
(GetIndividualInfoByMobileNoAndEmailQueryS {
,{ |!
IndividualInfoListVm	} ë
>
ë í
{ 
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
ILogger  
<  !;
/GetIndividualInfoByMobileNoAndEmailQueryHandler! P
>P Q
_loggerR Y
;Y Z
private 
readonly !
IIndividualRepository .!
_individualRepository/ D
;D E
public ;
/GetIndividualInfoByMobileNoAndEmailQueryHandler >
(> ?
IMapper? F
mapperG M
,M N
ILoggerO V
<V W<
/GetIndividualInfoByMobileNoAndEmailQueryHandler	W Ü
>
Ü á
logger
à é
,
é è!
IIndividualRepository ! 
individualRepository" 6
)6 7
{ 	
_mapper 
= 
mapper 
; 
_logger 
= 
logger 
; !
_individualRepository !
=" # 
individualRepository$ 8
;8 9
} 	
public 
async 
Task 
<  
IndividualInfoListVm .
>. /
Handle0 6
(6 74
(GetIndividualInfoByMobileNoAndEmailQuery7 _
request` g
,g h
CancellationTokeni z
cancellationToken	{ å
)
å ç
{ 	
try 
{ 
var 
	validator 
= 
new  #8
,GetIndividualInfoByMobileNoAndEmailValidator$ P
(P Q!
_individualRepositoryQ f
)f g
;g h
var   
validationResult   $
=  % &
await  ' ,
	validator  - 6
.  6 7
ValidateAsync  7 D
(  D E
request  E L
,  L M
cancellationToken  N _
)  _ `
;  ` a
if"" 
("" 
validationResult"" $
.""$ %
Errors""% +
.""+ ,
Count"", 1
>""2 3
$num""4 5
)""5 6
throw## 
new## 
ValidationException## 1
(##1 2
validationResult##2 B
)##B C
;##C D
var%% 
individualRecord%% $
=%%% &
await%%' ,!
_individualRepository%%- B
.%%B C2
&GetIndividualBookingByEmailAndMobileNo%%C i
(%%i j
request%%j q
.%%q r#
IndividualEmailAddress	%%r à
,
%%à â
request&&( /
.&&/ 0"
IndividualMobileNumber&&0 F
)&&F G
;&&G H
return(( 
_mapper(( 
.(( 
Map(( "
<((" # 
IndividualInfoListVm((# 7
>((7 8
(((8 9
individualRecord((9 I
)((I J
;((J K
})) 
catch** 
(** 
	Exception** 
ex** 
)**  
{++ 
_logger,, 
.,, 
LogError,,  
(,,  !
ex,,! #
,,,# $
$",,% '
$str,,' g
{,,g h
nameof,,h n
(,,n o
Handle,,o u
),,u v
},,v w
",,w x
),,x y
;,,y z
throw-- 
;-- 
}.. 
}00 	
}11 
}22 ™
”C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Queries\GetIndividualInfoByMobileNoAndEmail\GetIndividualInfoByMobileNoAndEmailValidator.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
QueriesF M
.M N/
#GetIndividualInfoByMobileNoAndEmailN q
{ 
public 

class 8
,GetIndividualInfoByMobileNoAndEmailValidator =
:> ?
AbstractValidator@ Q
<Q R4
(GetIndividualInfoByMobileNoAndEmailQueryR z
>z {
{ 
private 
readonly !
IIndividualRepository .!
_individualRepository/ D
;D E
public 8
,GetIndividualInfoByMobileNoAndEmailValidator ;
(; <!
IIndividualRepository< Q 
individualRepositoryR f
)f g
{ 	!
_individualRepository !
=" # 
individualRepository$ 8
;8 9
RuleFor 
( 
p 
=> 
p 
. "
IndividualEmailAddress 1
)1 2
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
. 
EmailAddress 
( 
) 
; 
RuleFor 
( 
p 
=> 
p 
. "
IndividualMobileNumber 1
)1 2
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ A
)A B
. 
NotNull 
( 
) 
. 
MaximumLength 
( 
$num 
) 
; 
RuleFor 
( 
e 
=> 
e 
) 
. 
	MustAsync 
( 
DoesIndividualExist *
)* +
.   
WithMessage   
(   
$str   g
)  g h
;  h i
}!! 	
private## 
async## 
Task## 
<## 
bool## 
>##  
DoesIndividualExist##! 4
(##4 54
(GetIndividualInfoByMobileNoAndEmailQuery##5 ]
e##^ _
,##_ `
CancellationToken##a r
token##s x
)##x y
{$$ 	
return%% 
await%% !
_individualRepository%% .
.%%. /
DoesIndividualExist%%/ B
(%%B C
e%%C D
.%%D E"
IndividualEmailAddress%%E [
,%%[ \
e%%] ^
.%%^ _"
IndividualMobileNumber%%_ u
)%%u v
;%%v w
}&& 	
}'' 
}(( Ï
ªC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Queries\GetIndividualInfoByMobileNoAndEmail\IndividualInfoListVm.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
QueriesF M
.M N/
#GetIndividualInfoByMobileNoAndEmailN q
{ 
public		 

class		  
IndividualInfoListVm		 %
{

 
public 
string 
IndividualFirstName )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
string 
IndividualLastName (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
string "
IndividualEmailAddress ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
string "
IndividualMobileNumber ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public "
IndividualLabDetailsVm %
IndividualLab& 3
{4 5
get6 9
;9 :
set; >
;> ?
}@ A
public 
int $
AdminBookingAllocationId +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
} 
} ±
ΩC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Individuals\Queries\GetIndividualInfoByMobileNoAndEmail\IndividualLabDetailsVm.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
Individuals: E
.E F
QueriesF M
.M N/
#GetIndividualInfoByMobileNoAndEmailN q
{ 
public 

class "
IndividualLabDetailsVm '
{ 
public 
int 
IndividualLabId "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
TestType 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} ò
±C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Locations\Queries\GetAllAvailableLocations\AvailableLocationListVm.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
	Locations: C
.C D
QueriesD K
.K L$
GetAllAvailableLocationsL d
{ 
public		 

class		 #
AvailableLocationListVm		 (
{

 
public 
int 

LocationID 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
LocationName "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
} Å
∑C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Locations\Queries\GetAllAvailableLocations\GetAllAvailableLocationsQuery.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
	Locations: C
.C D
QueriesD K
.K L$
GetAllAvailableLocationsL d
{		 
public

 

class

 )
GetAllAvailableLocationsQuery

 .
:

/ 0
IRequest

1 9
<

9 :
List

: >
<

> ?#
AvailableLocationListVm

? V
>

V W
>

W X
{ 
} 
} √
æC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Features\Locations\Queries\GetAllAvailableLocations\GetAllAvailableLocationsQueryHandler.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Features1 9
.9 :
	Locations: C
.C D
QueriesD K
.K L$
GetAllAvailableLocationsL d
{ 
public 

class 0
$GetAllAvailableLocationsQueryHandler 5
:6 7
IRequestHandler8 G
<G H)
GetAllAvailableLocationsQueryH e
,e f
Listg k
<k l$
AvailableLocationListVm	l É
>
É Ñ
>
Ñ Ö
{ 
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
ILocationRepository ,
_locationRepository- @
;@ A
private 
readonly 
ILogger  
<  !0
$GetAllAvailableLocationsQueryHandler! E
>E F
_loggerG N
;N O
public 0
$GetAllAvailableLocationsQueryHandler 3
(3 4
IMapper4 ;
mapper< B
,B C
ILocationRepositoryD W
locationRepositoryX j
,j k
ILogger 
< 0
$GetAllAvailableLocationsQueryHandler 8
>8 9
logger: @
)@ A
{ 	
_mapper 
= 
mapper 
; 
_locationRepository 
=  !
locationRepository" 4
;4 5
_logger 
= 
logger 
; 
} 	
public 
async 
Task 
< 
List 
< #
AvailableLocationListVm 6
>6 7
>7 8
Handle9 ?
(? @)
GetAllAvailableLocationsQuery@ ]
request^ e
,e f
CancellationTokeng x
cancellationToken	y ä
)
ä ã
{ 	
try 
{ 
var   
allLocations    
=  ! "
(  # $
await  $ )
_locationRepository  * =
.  = >
ListAllAsync  > J
(  J K
)  K L
)  L M
.  M N
OrderBy  N U
(  U V
x  V W
=>  X Z
x  [ \
.  \ ]

LocationID  ] g
)  g h
;  h i
return!! 
_mapper!! 
.!! 
Map!! "
<!!" #
List!!# '
<!!' (#
AvailableLocationListVm!!( ?
>!!? @
>!!@ A
(!!A B
allLocations!!B N
)!!N O
;!!O P
}"" 
catch## 
(## 
	Exception## 
ex## 
)##  
{$$ 
_logger%% 
.%% 
LogError%%  
(%%  !
ex%%! #
,%%# $
$"%%% '
$str%%' \
{%%\ ]
nameof%%] c
(%%c d
Handle%%d j
)%%j k
}%%k l
"%%l m
)%%m n
;%%n o
throw&& 
;&& 
}'' 
}(( 	
})) 
}** Ä'
~C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Profiles\MappingProfiles.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Profiles1 9
{ 
public 

class 
MappingProfiles  
:! "
Profile# *
{ 
public 
MappingProfiles 
( 
)  
{ 	
	CreateMap 
< '
AllocateBookingSpaceCommand 1
,1 2"
AdminBookingAllocation3 I
>I J
(J K
)K L
.L M

ReverseMapM W
(W X
)X Y
;Y Z
	CreateMap 
< /
#AllocateBookingSpaceCommandResponse 9
,9 :"
AdminBookingAllocation; Q
>Q R
(R S
)S T
.T U

ReverseMapU _
(_ `
)` a
;a b
	CreateMap 
< "
BookingsReportsListsVm ,
,, -"
AdminBookingAllocation. D
>D E
(E F
)F G
.G H

ReverseMapH R
(R S
)S T
;T U
	CreateMap 
< (
BookCovidTestCommandResponse 2
,2 3

Individual4 >
>> ?
(? @
)@ A
.A B

ReverseMapB L
(L M
)M N
;N O
	CreateMap 
<  
BookCovidTestCommand *
,* +

Individual, 6
>6 7
(7 8
)8 9
.9 :

ReverseMap: D
(D E
)E F
;F G
	CreateMap 
< )
SetTestOutcomeCommandResponse 3
,3 4
IndividualLab5 B
>B C
(C D
)D E
.E F

ReverseMapF P
(P Q
)Q R
;R S
	CreateMap 
< !
SetTestOutcomeCommand +
,+ ,
IndividualLab- :
>: ;
(; <
)< =
.= >

ReverseMap> H
(H I
)I J
;J K
	CreateMap 
< !
IndividualLabsRequest +
,+ ,
IndividualLab- :
>: ;
(; <
)< =
.= >

ReverseMap> H
(H I
)I J
;J K
	CreateMap 
< 
IndividualListsVm '
,' (

Individual) 3
>3 4
(4 5
)5 6
.6 7

ReverseMap7 A
(A B
)B C
;C D
	CreateMap   
<   #
AvailableLocationListVm   -
,  - .
Location  / 7
>  7 8
(  8 9
)  9 :
.  : ;

ReverseMap  ; E
(  E F
)  F G
;  G H
	CreateMap!! 
<!! 
LocationListsVm!! %
,!!% &
Location!!' /
>!!/ 0
(!!0 1
)!!1 2
.!!2 3

ReverseMap!!3 =
(!!= >
)!!> ?
;!!? @
	CreateMap"" 
<"" 
LocationDetailsVM"" '
,""' (
Location"") 1
>""1 2
(""2 3
)""3 4
.""4 5

ReverseMap""5 ?
(""? @
)""@ A
;""A B
	CreateMap## 
<## "
AvailableBookingListVm## ,
,##, -"
AdminBookingAllocation##. D
>##D E
(##E F
)##F G
.##G H

ReverseMap##H R
(##R S
)##S T
;##T U
	CreateMap$$ 
<$$ #
CancelBookedTestCommand$$ -
,$$- .

Individual$$/ 9
>$$9 :
($$: ;
)$$; <
.$$< =

ReverseMap$$= G
($$G H
)$$H I
;$$I J
	CreateMap%% 
<%% +
CancelBookedTestCommandResponse%% 5
,%%5 6

Individual%%7 A
>%%A B
(%%B C
)%%C D
.%%D E

ReverseMap%%E O
(%%O P
)%%P Q
;%%Q R
	CreateMap&& 
<&&  
IndividualInfoListVm&& *
,&&* +

Individual&&, 6
>&&6 7
(&&7 8
)&&8 9
.&&9 :

ReverseMap&&: D
(&&D E
)&&E F
;&&F G
	CreateMap'' 
<'' 
IndividualLabListVm'' )
,'') *
IndividualLab''+ 8
>''8 9
(''9 :
)'': ;
.''; <

ReverseMap''< F
(''F G
)''G H
;''H I
	CreateMap(( 
<(( "
IndividualLabDetailsVm(( ,
,((, -
IndividualLab((. ;
>((; <
(((< =
)((= >
.((> ?

ReverseMap((? I
(((I J
)((J K
;((K L
})) 	
}** 
}++ ô
{C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Application\Response\BaseResponse.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Application% 0
.0 1
Response1 9
{ 
public		 

class		 
BaseResponse		 
{

 
public 
BaseResponse 
( 
) 
{ 	
Success 
= 
true 
; 
} 	
public 
BaseResponse 
( 
string "
message# *
=+ ,
null- 1
)1 2
{ 	
Success 
= 
true 
; 
Message 
= 
message 
; 
} 	
public 
BaseResponse 
( 
string "
message# *
,* +
bool, 0
success1 8
)8 9
{ 	
Success 
= 
success 
; 
Message 
= 
message 
; 
} 	
public 
bool 
Success 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Message 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} 