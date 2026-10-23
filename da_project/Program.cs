using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace fazfuck
{
    internal class Program
    {
        static string[] funnyimages = { @"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
:==========================================================:
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@@@@@@@@@@%%%%%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@  *@ @% .@@@%%%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@@@ @@@   *- # @@%%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@ @  @@@ @@@@ @ @@@%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@ @  @@ @@@#%@:@:  @@%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@ @@@@@@###@@@ *   @%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@ @ @@ %---+@ @@@ @@@%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@  @@@*@@@@@ @@@@%@%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@  @  @@@ *%@@   @@%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@@.  @*- @@@+ # @@%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@=@:%@@    % @@%%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@%*#@%%% @@@ @ @@%%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@.#####@.@#@    @@%%%%%%%%%=
=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@%@###%@ @#%@@@ @@%%%%%%%%%=
#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @@%#%:@@%@@@@ @@@@@@@@@@@#
.===============================%@..@@@@ @@.   @#==========.
.################################@@%@   @.@@   @###########.
.##########################%@@@@@@@@@ @@@#%@ @ @@@%@@@@####.
.########################@@@%  -=  .@ @@ @@@ @ @  @@  @####.
.++++++++++++++++++++++++@.% @@@@ @@@@@    @@#@@@@@@@ @++++.
+@@@@@@@@@@@@@@@@@@@@@@@@@.@ @@@@@@##%@@@@@%##@ @@@%  @@@@@+
-%%%%%%%%%%%%%%%%%%%%%%%@ = -  # @@@@@-%##++++**  %%@@@%%%%-
-%%%%%%%%%%%%%%%%%%%%%%%@@@@@@@+.  :  ## ######@@@@%%%%%%%%-
.-----------------------------+%@@@@@@%%#*-----------------:
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@", @"                                  #++=++============================================
 . . . . . . .  .    .... .  -@@ *@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
                . . .    .   -@@ +@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
 .......... .   .     .    . .@@ +@%%%%@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
            ..  . . . . . .  :@% +@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
 . . . . .    . .     . . .. .@% +@@%%%%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
           ..       ... :    .@% =@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
         :. .. .... .   :  . .@@ =@%@%@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
 .....       .. ...... :.. .  @% =@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=
    . .                       *=  @####%#*%##########%#######%%##%%%%%#%%%%%%%%%%#%=
 ....                         :-  @#**#********####*#*#######**##*****************#-
        :@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+
 . ..   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
    ... @@@%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
        @@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
    .   @@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@* +@  @@@@@@@@  @@@@@@@@@@@%%@@@@@@#
 . ..   @@@@@@@@@@@@@   =@@   %@@=   @     @@@@@  :@  @@    @@ .@@ =@@   #@@@@@@@@@*
      . @@@@@@@@@@@@ @@@@@ @@@  @. @@@ .@@  @@@@# @@  @@@@@ :@.:@ @@@ @@@ @%%%@@@@@+
      . @@@@@@@@@@@@ @@@@@ @@@  @: @@@ =@@  @@%@  @@  @@  @  @:   @@@ @@@@@@@@@@@@@%
 .   .. @@@@@@@@%@@@     @     @@  @@@  @@  @@@@  @@  @  %%  @  @@  @     @@@@@@@@@*
        @@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@%
 .      @@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+
     .  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*
                                  #=:*@@@@@@@@@@@@@@@@@@@=.:        ..:...:......:: 
                              @@@ %@@@@@@@@@@@%%@@@@@@@+:*=+**#**####**************=
                          :%@.  -         @@@@@@@@@@@@#***###**#*******************=
                        %@@@@@@=  @=#@@@@%*@@=        @@%%*#***#*#########*#*######=
                      .@%*++++%@@  @@%%#@@=    @@@@@+   @%%%%#*##**********##**###*=
                .    :@%#*==+=**@%  @*%@*   @@@##**%#@%  @%**#***#####*###*##*****#=
            . .     #@#*====*+==+@: @@@+  @%*+*+=++*+**#  @#***##****#*****#*###**#=
       ..           @*=++**++**+=%@  @@  @%#+*+++*==+*#@  @@####*###*#**#**##*#*#**=
                   @%**===++++++++@  @% =@+*=-++++=+==*@+ #@%###******#*##***#***#*=
               :+  @**+=++++++++++@. @  @*+***+*=+*+*=+##  @%****#*#**#**#*##*#*#*#=
         .=*%%@@@ -%=*=*+=+++*+++*@- @ :@*+*++=*++*+=+**@  @%#**##*##*#####****#***=
  .-*@@@@@@@@@@@= #%=*-*+=+++*+++*@    @%*+*++=*+=*++*+*@  @%#***#*****************=
 @@@@@@@@@@@#= =  @%=++*++++=+++++@    @*++*+*****++*=*@*  @%#####*%####***########=
 @@@@@%=:      @  @**+++++=*++++++@   %#+*=**++*+++=++*@= :@%****#*######**####***#=
 *.      :#@@@@@+ @#++++++++=*+*++%*  @#*==++=====***+=@  @@#%#%#*********##**##*#+-
   :+@@@@%%##=*@: @%+++=++=*=*****+%@@%+++*=*+**#+*=+*%%  @%%%****+##%%##***#**%#%#*
=@@@%%%+###*%+%@- #%=++=+*=*@@@@@@@%*==**+*#@@@%#*=***@  @@@*::%%%%%***###**%#+#****
+#*%#+*#**%=**#@= %%=+++=*%@       =@*=+*%@=    =@@%*+.     @@@@*#*********##*%%%#*=
=**+##**#*%#%**@* %%=+++++%  @@@@@%  @+*@:   @@*   #%%@%@*.    @@%##*##%%###*+*:.=*=
=#*#*###**#*#*#@- @*+=++=+@  @@: :@: %**%  @@@@@@= :@=***@@@@#   @@%%#*****###%%%%#=
=#######*##*%*%@  @*=+++=+@  @@* =@: %%*@ +@@   @@  @%=*+*==*#@%  .@%+%%#*****%#%#%=
=************+#@  @*++**==**  @@@@#  @++@  @@@@@@@  @*+++++**=*%@=  @@#+*#*#*#*****=
=**##*######*#%@  @*=+*==**@%      :%*+=%@   @@@*  :@*==+=++**+*#@* .@*###%%%###**#=
=#*%#*##%%%#%%*@- @*+=+*+#=+*@%@@@@@**+==*@+      @##+=+++==+=-+=*@  @%#*#***#*#**#=
=***###****#***%@  @%++*=+++=+=#--@*=**=*+=@@@@@@%#****++***+++*+=@  #%*#*##*+*****=
=######**#***#*#@@  *@%++++++=+%:  @@%#**%@@:  =*===*=++++*+*===*%@  @%*#*#*####**#=
=****####*****#*%@@+  :@@@#*+++=%@   =@@@@   :@***++*+**+*=+*=#@@@  @@%%%#*#*******=
=#******#%%%###*#%#@@#    %@@%@**%@@%      =@%**+++++*+++%%%@@@%   #@%#****##**##%#=
=######+*****#**#*#%%@@@@     +%@@@@%@@@@@@@**++=+++*%@@@@@+.    .@@%%+=**######*##=
-*****#%####****#**=+**#%@@@%:         @#****++*=*+=#.       :@@@@%#+#%##*********+-
=#*%#%%%##*#######%%###*##%@#+@@@@ +@  @+====+=*=*=+%# @@@% @@@@@@@@@#*%*#*###%%%%%=
=###**=+=###***#**++*#%*#%*  :  %  @@  @*%==+++==*=*@@   @@@  @@.   @@***%*##**####=
=#****%%#***####*%%%%#*%*%@ .@@@  @@ :  @+++****++*=@- @:  @@.   @@  @%*##***+***+*=
-*###******##*##*****+***%@@   %@@@  @: =@%===+=+=**@  @@@  :@@@@:  @@%%**####%**%%=
+%****###*##**+********+***  @@.%@@  %@- *@#=*=++*@@  =@%  :@@@@    .@@****=+=+**#*=
=*#****+=::.::.:  . ===:-++  @  @  @@  @@ .@@@@%@@@  @@@  @@  @:@@@@  @#--====+:    
  .::-::@@@@@@@@@@@@@@@@@@@@    @+     @     :%%.   @@@@@     @       :@@@@@@@@@@@@@
@@@@@@@@@@@@%@@@@@@@@@@@%@@@@@@    @@@@@ %@%     +@  @@@@@@@+ @  @@:@@@@@@@@@@@@@@@@
@@@@@@@%@%@@%@@@@@@@@@@@@@%@@@@@@@@@@@@@ @@# @@@ @@  @@@@@@@@    @@@@@@@@@@@@@@@@@@%
#@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ *@@ @@@ %@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%@#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@         #@@ @@@ %@*  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%*%@@@@@@@@@@@@@@@@@@@@@@@@@@@%@  @@@@@@@@@@ @@@ %@@.     @@@%%%@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@     :+@@+  @@@ %@@@@@@@-  @@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@#       @@@@  %%@@@@@@  @@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%@@@@@@@@@@@@@@@@          @@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@", @"=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
 .@#######**++##%%@=@%@##*=--#****%@@==#+#=+=*%=%%##=+**##%%..... #@... .=@.-   =%@@-.:..*%.      @      =@#   #+:   -+##:
 .@#####%#=+#*+-.. @@@@@-  .+===+%@ @@@% @@%%#%+@@@@@%+###% ***+=-*.#@@@%.@ @@@@*#  @%%%#@  @@@@@ %%@@@@@@  @@@* @@@@@-*@-
 *@#####%##@%%@@    +*:-*@@@@@@@@@ @#=*@@ @#%%%:@  @ :#=##@.#%@%@@@ @@ @@ @ @@ @@@%%# @@ @@ @@ @=@@*@@  @@ @ @  @@.= @@ @:
 @%%%@@@@  @@%@%*%%@@#@@@@  @@@@@@ @@@ @@ @##%@+@@@@@@#=*#@ #*%   @ @@ @@ @ @@  @@##@ @@ @@ @@ @%@@-@@  @@ @=@%%.@@@ %#@@-
 @%@@   ..  %%+-%@@@%@@  @@@@    @ @@@@@ @@#%%%%=+@@@%=**#@ ##@@@+@ @@ @@ @ @@@@# .%@ @@ @@ @@@@@ @.@@@@  @@#@#@# @@@@ @@-
 :..::==.. ##+@@@%%%%@.=@=@@@@ @@@@@   @@@###%%%@@*#*%***#@ #*-*#@@%#.%*@ @ @@  @@ @@ @@ @@ @@ @ :*.@@  @@ @#@*     @@@ @-
 ======. @%@@@%#@@@@@@ @@==+@* @%%%@@@@@%%#%%%%@@@@@  %###@ ##-+%@ @@@@#@#@ @@ -@% @@ @@ #@ @@ %%@@+@@  @@ @#@# @@@# @@ @-
 =----: @@%%%@@@@+  @@@ @%@@  @@#%%##%%%%%%%%##=-   .*%###@:@@@@%@ @@ @ @@* @@ %@@ @@ @@ @@ @@@@@@@@@@  @@ @#@=+ @@@@@@ @:
 ===-. @@@@@@   @@@@@#@@@: @@@@%#%%##%%%%%%%%*%@@@. @@*###@:   %#@    @        -   @@    @@       @   .    @#@=*:     %*@-
 --=*#@@@   @@@@@%#######%%%%#%%%%%%%%#@@@%=+@%%%@@# @@%##%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%==##@@@@@##-
 ==-    @@@@@###%%%%%%%%%%%%%%%%@@@%@@@@ -%%%@ @#%@@ ..@%#%#     -*#@#    :%:-:@@:-%@  ... +%@%%%%@@@@@@@@*=@**+=.@*###*#-
 =-.@@@@@%%%%%%%%%##%%@@@@@%%%%%@ @%@ @@@#*@@@@@%#%@@...@%@ @@@@@@@-@ @@@@@# @@  @@  @@@@@@@ @%%##%####%###%#=#==:@######-
 == @%%%%#%%%%%%%%%%%%=++=*%%##%@ @%@@@%%%@@#*@%%%%@@ -:.@% @@-* @@ @ @@ @@ =@@  @@* @@ - @@ @------::::.... ..:-+#######-
 =- @%%###%%%%%%%%#%@=*#***=%%%%@%@@@@%%@@@@  @%#%%-@   :%@ @@%@ @@ @ @@ @@ @ @@@@ @    # @@ % :=++++**+=*#@@@#@+=**###*#-
 == @%%%%%##%%%%%%#%%=*###+=%%%%%#@ =@@@@#    @%%%@@@.@# @@ @@%@ @@ @:@@ @@ @ @@@@ @@   @@@@ @*@*++*=*+#@******+%%=*#***#-
 =- @@%#%%%%%%%%%%#%%%=====%@%%%%%@@         :@%%%@%=  @ #@ @@%@ @@ @@@  @@ @@ @@ @%@@@@@  %**=+#@@@*@@@@*===+=@@****+=+#=
 ==: @@%%%%%%%%%%%%%%@@@@@@%%%%%##%@@        @@%%:@% =@ .-@ @@+# @@  @@@@@@%*@ @@ @+#   #@@@#*##*+ @:@+   @+%@#+=***=*%*=+
 -== .#@%#%%%%%%##%#%%%%%%%%##%%#%%%@@@*=-*@@@@@#@+ #+ :-.:=@@@@@@@. @@  %@@ @ @@ @#@@@@##@ @+*@@@@.@@#@@@@=#@@@@:==@%@=+=
 =-  @@#@@%%%%%%##%%%%%%%%%%##%%%%%%#@@@@@@@%% %@+*#%%#.-=:#      %@    @    @    @%=   .*@ @@*==:@%%@%-..:+=+  @@-%:-***-
 -++@   -%@%%%%%%%%%%%##%%%%#%@@@%%%%%%%%@@@@@@@ **+**@%=..@@@@@@@@@@@@@@@@@@@@@@@@#%@@@@@%*#+**+=#@%%%@@@@@#%@@@-:@@*+*#:
 =- @@  .++=%@@%%%%%%%##%%%%#%@ @%%#@-@%%@ %@#=+##*****#%.*@###%%##########%#%%%#%:@%%%%%@%%@#%%**+=+%@@@@@@@%+:-%@@@@**#-
 -=:  -@%#**:=+#@@@%%%%%%%%%#%-.@%%%@ @%@@@:*-*++**+****#-@%%####*+**##***+*:==***@%#########%%#%@**@@@@#@@@@@%@@#==*%@=*-
 ==--::#-*****+-+==*%%%@@@@@@@@@@@@%@@%+=-**#+*******+*+*%.@@%#%+@@@*****%@%%@%@@.@#%#%#####%####@-@@:     -*@@#=***++@=*:
 ==--.+%***********+-:============---=+************+*+***%+: @%# *=+====--%%#%%%+-@*@#%%%%%%%%%#%@+@.        =@*=***=+@=*:
 ====*##****************************+*********************#=- @#*-%@@@:@@@@==-*=#=%%%*%%%%%@@@@%@*+-         -@@#=+*%@#=*-
 ===:=%**************************************************#%=-: %%@@ .%*@*  -@=@*+=#==+=%@%* .-@@+.:%@@@@@=   =@@%@@@@#=@#=
 ===.#%++*******+***+***********+*******+****+*******+**+#%+:. %+%@@#*%%#@@@-%@@%*=-%-#@++@@@@+ ..@@ =@@@@@@-@@%%%%@#+#@  
 ===-#%***++********+*******+***********+*******+****+****%-=.@@#==#%%%###++@%  @@=#==@.=.#@@.*@@@ @@#.#@@@@@@@@@@@@=@=@@#
 ----#%*********+***+*******+***********+*******+****+***#%.- @@:++=#%%%%%#@#@@@*-%@%=.**= @@@ @%@ @@@-::*#@@@@@%+.--.@@%=
 ===:#%*****************+********************+**+****+***%+:=. @@@%#%-@@@@@@%@@@@@@@@+ .. %@@@@@-%@@@@@:----::-----+*-*@@=
 =+*:####*#*########************************************#%=-== @@@@%*%%   +%@%#+=+=+@=@@@@@@@@@@@@# +@=.+%@@@-++++++=*: @*
:=-::::..:::::-:...=%##**********************++******+**%*:---  * #@-@      @@%+*#+=@* @@@@...@@@@ %@@@+=-::-=+++++=+*=*.*
.+###*#######%#:.+#+- %##***********+**************+++#%#::=-- @@=@@+%@@@@= @@%=+=#@#%@=@+:+*=.*@@@ @*.-=+++++++++++=++.@+
.+*++++++++++= @@%##@%..#***+**++********+***+**+***#*%#::=:   @@@+@.-**@@@@@@@@@@#*. @ ..-=+*+@@@@#:--+=+++++++++++++*:@=
.=++++++++++* @%*****%@ %%**************************#%* ... @@@%@@-@.*=::-=====+=.@.*.*@@@%%=++=. .---=+++++++++++++=+*:*#
.+++++++++++# @#******%= %**************************#*.@@@.+@%%%@@@ .#*++++++++++-@@=+ @%%%@@@ ----======+*+**+*******#=:%
=@@@@@@@@@@@@+@@@@@@@@@@=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=@@@@=@@@@@#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%#%%#%%%%-@", @"                             :=====                #######
                        . . ==-:  = .              #######
 .. .. .. -*===.. .. .. .  ==:: . . . .. .. .. .   #######
  .  . ====---===== .  ..=+========. . === . . .    ######
--.. . :   :-..= :=+==========-     ==:...::-. .    ######
------....... ..=====- .=======-*   .*== . . . ..   ######
----------.....====- ***= -====-#-:: :===........   ######
-----------=========#.  .-=-====:%@=.#=:==.......   :#####
------+===---+=====*%.::::+:======***= -=========    #####
---==-:   ---=======*%-=.#+:=========-======::= :-   #####
--=-. =------========+***+--=================.....   #####
--= ---------=====-===-:.:====================:::    #####
-------==----====-=============================::     ####
------*====-======-=============================      ####
-------+=-=======---=================---------===     ####
------====-.====-=--=============--:::         :==    ####
-----==-: ========---========--:::               =    .###
----==- ==========---======-::                   :=    ###
---==- ===========----====-:                     :=    ###
---=-=@============-======:                     :==    ###
------===========:==-====-                   ::-==:    ###
------============-==-=-=:               .::--===+      ##
----*-=============-======            :::--=====+       ##
-----=============-=-===-==       .:::--=========       ##
-----%============---=-=====:::::-==============-::.    ##
-----==============-==    =======================-:::   -#
-----=============-           =================-=%=--    #
---=-============              :===========--==*=%===    #", @"          :::       
    ::..:.-::=      
   =*=.::-.::..:-   
 =*+:.::--@%%-:-=   
====.:%%%@##%@:==+  
 ***:%=*%%@#+@@:#==+
   *:#%#+#%%%@@%%%%=
      ::==-=-==:    
     ::-======:-    " };
        enum verbosity { not, seperateline, runline, variables, thing };
        static verbosity verbose = verbosity.not;
        static bool dorun = true;
        static string currentfile = "";
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to fazfuck fucker");
            if (args.Length != 0)
            {
                currentfile = args[0];
                runnewprogram();
            }
            while (true)
            {
                Console.WriteLine("commanddd");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "v_not":
                        verbose = verbosity.not;
                        break;
                    case "v_seperateline":
                        verbose = verbosity.seperateline;
                        break;
                    case "v_runline":
                        verbose = verbosity.runline;
                        break;
                    case "v_variables":
                        verbose = verbosity.variables;
                        break;
                    case "v_thing":
                        verbose = verbosity.thing;
                        break;
                    case "dump":
                        dumpdata();
                        break;
                    case "rerun":
                        if (currentfile == string.Empty)
                            Console.WriteLine("no program to run! you STUPID.");
                        else
                            runnewprogram();
                        break;
                    default:
                        if (!File.Exists(command))
                            Console.WriteLine("not exist");
                        else if (command.EndsWith(".fzfk"))
                        {
                            currentfile = command;
                            runnewprogram();
                        }
                        else
                            Console.WriteLine("wrong filetype");
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "currentprogram":
                        Console.WriteLine(currentfile);
                        break;
                }
                
            }
        }
        static void runnewprogram()
        {
            lines = File.ReadAllLines(currentfile);
            //reset these things
            counter = 0;
            boolvars = new Dictionary<string, bool>();
            numvars = new Dictionary<string, float>();
            stringvars = new Dictionary<string, string>();
            thingvars = new Dictionary<string, object>();
            pointers = new Dictionary<string, int>();
            isinhook = false;
            linereturn = new List<int>();

            dorun = true;
            run();
            while (dorun)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey keykey = Console.ReadKey(true).Key;
                    if (keykey == ConsoleKey.Escape)
                        dorun = false;
                    else
                        run_hook("#console_keypressed", keykey.ToString());
                }
            }
            Console.WriteLine("program finished");
        }
        static string[] lines;
        static Dictionary<string, bool> boolvars = new Dictionary<string, bool>();
        static Dictionary<string, float> numvars = new Dictionary<string, float>();
        static Dictionary<string, string> stringvars = new Dictionary<string, string>();
        static Dictionary<string, object> thingvars = new Dictionary<string, object>();
        static string[] progbools = { "ISINHOOK", "console_capslock", "console_keyavailable" }; //add your program variables here
        static string[] prognums = { "COUNTER", "PROGRAMVERSION", "IMPLEMENTATIONVERSION" };
        static string[] progstrings = { "PROGRAMNAME", "console_windowtitle" };
        static string[] progthings = { "INVALID", "funnyimg_garfield" };
        static int counter = 0;
        static Dictionary<string, int> pointers = new Dictionary<string, int>();
        static bool isinhook = false;
        static List<int> linereturn = new List<int>();

        static Random randomizer = new Random();
        static void run()
        {
            try
            {
                while (counter < lines.Length)
                {
                    string[] line = seperateline(lines[counter].TrimStart());
                    if (line.Length == 0) //empty line
                    {
                        if (verbose == verbosity.runline)
                            debugline(counter + ": EMPTY LINE/nO FUNCTION");
                        counter++;
                        continue;
                    }
                    if (verbose == verbosity.runline)
                        debugline(counter + ": " + string.Join("|", line));
                    if (line[0].StartsWith("#") || line[0].StartsWith("&"))
                    {
                        if (pointers.ContainsKey(line[0]))
                            doerror("pointer " + line[0] + " was already defined as line " + pointers[line[0]] + "!");
                        else
                        {
                            pointers.Add(line[0], counter);
                            if (verbose == verbosity.runline)
                                debugline("defined pointer " + line[0] + " as line " + counter);
                            skipindentation(1); //searches for first {
                            skipindentation(0); //skips the inside cuz brackets
                        }
                    }
                    else if (line[0].StartsWith("%"))
                    {
                        if (pointers.ContainsKey(line[0]))
                        {
                            pointers[line[0]] = counter;
                            if (verbose == verbosity.runline)
                                debugline("changed pointer " + line[0] + " to " + (counter));
                        }
                        else
                        {
                            pointers.Add(line[0], counter);
                            if (verbose == verbosity.runline)
                                debugline("defined pointer " + line[0] + " as line " + (counter));
                        }
                    }
                    else
                    {
                        switch (line[0]) //run function
                        {
                            default:
                                doerror("the function " + line[0] + " doesn't exist!");
                                break;
                            //variable handling
                            case "set_boolvar": //bool var, bool
                                setvar_bool(line[1], parsebool(line[2]));
                                break;
                            case "set_numvar": //num var, num
                                setvar_num(line[1], parsenum(line[2]));
                                break;
                            case "set_stringvar": //string var, string
                                setvar_string(line[1], parsestring(line[2]));
                                break;
                            case "set_thingvar": //thing var, thing
                                setvar_thing(line[1], parsething(line[2]));
                                break;
                            case "remove_boolvar": //bool var
                                {
                                    if (varexists_bool(line[1], out bool isprogram))
                                    {
                                        if (isprogram)
                                            doerror("program boolean variable " + line[1] + " cannot be removed!");
                                        else
                                            boolvars.Remove(line[1]);
                                    }
                                }
                                break;
                            case "remove_numvar": //num var
                                {
                                    if (varexists_num(line[1], out bool isprogram))
                                    {
                                        if (isprogram)
                                            doerror("program number variable " + line[1] + " cannot be removed!");
                                        else
                                            numvars.Remove(line[1]);
                                    }
                                }

                                break;
                            case "remove_stringvar": //string var
                                {
                                    if (varexists_string(line[1], out bool isprogram))
                                    {
                                        if (isprogram)
                                            doerror("program string variable " + line[1] + " cannot be removed!");
                                        else
                                            stringvars.Remove(line[1]);
                                    }
                                }
                                break;
                            case "remove_thingvar": //thing var
                                {
                                    if (varexists_thing(line[1], out bool isprogram))
                                    {
                                        if (isprogram)
                                            doerror("program thing variable " + line[1] + " cannot be removed!");
                                        else
                                            thingvars.Remove(line[1]);
                                    }
                                }
                                break;
                            //variable operations
                            case "math": //num ref, operator, num
                                {
                                    float num1 = parsenum(line[1]);
                                    float num2 = parsenum(line[3]);
                                    float result = 0f;
                                    switch (line[2].ToLowerInvariant())
                                    {
                                        case "+":
                                            result = num1 + num2;
                                            break;
                                        case "-":
                                            result = num1 - num2;
                                            break;
                                        case "*":
                                        case "x":
                                        case "×":
                                            result = num1 * num2;
                                            break;
                                        case "/":
                                        case "÷":
                                            if (num2 == 0f)
                                            {
                                                doerror("cannot divide by 0!");
                                                if (num1 == 0f)
                                                    result = 0f;
                                                else if (num1 < 0f)
                                                    result = float.NegativeInfinity;
                                                else
                                                    result = float.PositiveInfinity;
                                            }
                                            else
                                                result = num1 / num2;
                                            break;
                                        case "%":
                                        case "m":
                                        case "mod":
                                            if (num2 != 0f)
                                                result = mod(num1, num2);
                                            else //i think n%0=0 makes sense
                                                result = 0f;
                                            break;
                                        case "^":
                                        case "p":
                                        case "pow":
                                            result = (float)Math.Pow(num1, num2);
                                            break;
                                        default:
                                            doerror(line[2] + " is not a valid operator!");
                                            break;
                                        case "@": //from assmade (it's useless but funny to have)
                                            result = (float)Math.Pow((((float)Math.Pow(num1, num2) / num2) + mod(num2, num1)) / mod(num1 + num2, 3.3f), num1 - num2);
                                            if (result == float.NaN)
                                                result = 2.21f + mod(num2, 1f) + mod(num1, 0.5f);
                                            break;
                                    }
                                    setvar_num(line[1], result);
                                }
                                break;
                            case "math_abs": //num ref
                                {
                                    float num = parsenum(line[1]);
                                    if (num < 0f)
                                        setvar_num(line[1], -num);
                                }
                                break;
                            case "math_round": //num ref, num
                                {
                                    float num1 = parsenum(line[1]);
                                    float num2 = parsenum(line[2]);
                                    if (num2 == 0f)
                                        doerror("cannot round to a muliple of 0!");
                                    else
                                        setvar_num(line[1], (float)Math.Round(num1 / num2) * num2);
                                }
                                break;
                            case "math_random": //num ref, num, num
                                {
                                    float num1 = parsenum(line[2]);
                                    float num2 = parsenum(line[3]);
                                    float startnum = Math.Min(num1, num2);
                                    setvar_num(line[1], (float)(randomizer.NextDouble() * (Math.Max(num1, num2) - startnum)) + startnum);
                                }
                                break;
                            case "math_random_round": //num ref, num, num
                                {
                                    int num1 = (int)parsenum(line[2]);
                                    int num2 = (int)parsenum(line[3]);
                                    setvar_num(line[1], randomizer.Next(Math.Min(num1, num2), Math.Max(num1, num2)+1));
                                }
                                break;
                            case "math_sin": //num ref
                                setvar_num(line[1], (float)Math.Sin(parsenum(line[1])));
                                break;
                            case "math_cos": //num ref
                                setvar_num(line[1], (float)Math.Cos(parsenum(line[1])));
                                break;
                            case "math_tan": //num ref
                                setvar_num(line[1], (float)Math.Tan(parsenum(line[1])));
                                break;
                            case "math_log": //num ref, num
                                {
                                    float num1 = parsenum(line[1]);
                                    float num2 = parsenum(line[2]);
                                    if (num2 <= 0f)
                                        doerror("logarithm base cannot be 0 or negative!");
                                    else
                                        setvar_num(line[1], (float)Math.Log(num1, num2));
                                }
                                break;
                            case "math_sqrt": //num ref
                                {
                                    float num = parsenum(line[1]);
                                    if (num < 0f) //haha teehee
                                        setvar_num(line[1], -(float)Math.Sqrt(num));
                                    else
                                        setvar_num(line[1], (float)Math.Sqrt(num));
                                }
                                break;
                            case "math_sign": //num ref
                                {
                                    float num = parsenum(line[1]);
                                    if (num > 0f)
                                        setvar_num(line[1], 1f);
                                    else if (num < 0f)
                                        setvar_num(line[1], -1f);
                                    else
                                        setvar_num(line[1], 0f);
                                }
                                break;
                            case "math_min": //num var, num, num
                                {
                                    float num1 = parsenum(line[2]);
                                    float num2 = parsenum(line[3]);
                                    if (num1 < num2)
                                        setvar_num(line[1], num1);
                                    else
                                        setvar_num(line[1], num2);
                                }
                                break;
                            case "math_max": //num var, num, num
                                {
                                    float num1 = parsenum(line[2]);
                                    float num2 = parsenum(line[3]);
                                    if (num1 > num2)
                                        setvar_num(line[1], num1);
                                    else
                                        setvar_num(line[1], num2);
                                }
                                break;
                            case "logic": //bool ref, operator, bool
                                {
                                    bool bool1 = parsebool(line[1]);
                                    bool bool2 = parsebool(line[3]);
                                    bool result = false;
                                    switch (line[2].ToLowerInvariant())
                                    {
                                        case "&":
                                        case "&&":
                                        case "and":
                                            result = bool1 && bool2;
                                            break;
                                        case "|":
                                        case "||":
                                        case "or":
                                            result = bool1 || bool2;
                                            break;
                                        case "^":
                                        case "xor":
                                            result = bool1 ^ bool2;
                                            break;
                                        default:
                                            doerror(line[2] + " is not a valid operator!");
                                            break;
                                    }
                                    setvar_bool(line[1], result);
                                }
                                break;
                            case "compare_num": //bool var, num, operator, num
                                {
                                    float num1 = parsenum(line[2]);
                                    float num2 = parsenum(line[4]);
                                    bool result = false;
                                    switch (line[3].ToLowerInvariant())
                                    {
                                        case "=":
                                        case "==":
                                            result = num1 == num2;
                                            break;
                                        case "!=":
                                            result = num1 != num2;
                                            break;
                                        case ">":
                                            result = num1 > num2;
                                            break;
                                        case "<":
                                            result = num1 < num2;
                                            break;
                                        case ">=":
                                        case "=>":
                                            result = num1 >= num2;
                                            break;
                                        case "=<":
                                        case "<=":
                                            result = num1 <= num2;
                                            break;
                                        default:
                                            doerror(line[3] + " is not a valid operator!");
                                            break;
                                    }
                                    setvar_bool(line[1], result);
                                }
                                break;
                            case "compare_string": //bool var, string, operator, string
                                {
                                    string str1 = parsestring(line[2]);
                                    string str2 = parsestring(line[4]);
                                    bool result = false;
                                    switch (line[3].ToLowerInvariant())
                                    {
                                        case "=":
                                        case "==":
                                            result = str1 == str2;
                                            break;
                                        case "!=":
                                            result = str1 != str2;
                                            break;
                                        case "contains":
                                        case "ct":
                                            result = str1.Contains(str2);
                                            break;
                                        case "!contains":
                                        case "!ct":
                                            result = !str1.Contains(str2);
                                            break;
                                        case "startswith":
                                        case "stw":
                                            result = str1.StartsWith(str2);
                                            break;
                                        case "!startswith":
                                        case "!stw":
                                            result = !str1.StartsWith(str2);
                                            break;
                                        case "endswith":
                                        case "enw":
                                            result = str1.EndsWith(str2);
                                            break;
                                        case "!endswith":
                                        case "!enw":
                                            result = !str1.EndsWith(str2);
                                            break;
                                        default:
                                            doerror(line[3] + " is not a valid operator!");
                                            break;
                                    }
                                    setvar_bool(line[1], result);
                                }
                                break;
                            case "compare_thing": //bool var, thing, operator, thing
                                {
                                    object obj1 = parsething(line[2]);
                                    object obj2 = parsething(line[4]);
                                    bool result = false;
                                    switch (line[3].ToLowerInvariant())
                                    {
                                        case "=":
                                        case "==":
                                            result = obj1 == obj2;
                                            break;
                                        case "!=":
                                            result = obj1 != obj2;
                                            break;
                                        default:
                                            doerror(line[3] + " is not a valid operator!");
                                            break;
                                    }
                                    setvar_bool(line[1], result);
                                }
                                break;
                            //some text stuff
                            case "print": //string
                                Console.WriteLine(parsestring(line[1]));
                                break;
                            case "printn": //num
                                Console.WriteLine(parsenum(line[1]).ToString(System.Globalization.CultureInfo.InvariantCulture));
                                break;
                            case "num_to_string": //string var, num
                                setvar_string(line[1], parsenum(line[2]).ToString(System.Globalization.CultureInfo.InvariantCulture));
                                break;
                            case "string_replace": //string ref, string, string
                                setvar_string(line[1], parsestring(line[1]).Replace(parsestring(line[2]), parsestring(line[3])));
                                break;
                            case "string_join": //string ref, string
                                setvar_string(line[1], parsestring(line[1]) + parsestring(line[2]));
                                break;
                            case "string_sub": //string var, string, num, num
                                setvar_string(line[1], parsestring(line[2]).Substring((int)parsenum(line[3]), (int)parsenum(line[4])));
                                break;
                            case "string_length": //int ref, string
                                setvar_num(line[1], parsestring(line[2]).Length);
                                break;
                            case "string_lower": //string ref
                                setvar_string(line[1], parsestring(line[1]).ToLowerInvariant());
                                break;
                            case "string_split_count": //num var, string, string
                                setvar_num(line[1], parsestring(line[2]).Split(parsestring(line[3]).ToArray()).Length);
                                break;
                            case "string_split_index": //string var, string, string, num
                                int index = (int)parsenum(line[4]);
                                if (index < 0)
                                {
                                    doerror("index " + index + " is under split bounds!");
                                    break;
                                }
                                string[] splat = parsestring(line[2]).Split(parsestring(line[3]).ToArray());
                                if (index >= splat.Length)
                                    doerror("index " + index + " is over split bounds!");
                                else
                                    setvar_string(line[1], splat[index]);
                                break;
                            //program control
                            case "if": //bool
                                counter++; //go to indentor
                                if (!parsebool(line[1]))
                                    skipindentation(0); //on indentation so we skip from there
                                break;
                            case "goto_line": //num
                                counter = (int)parsenum(line[1]) - 1;
                                break;
                            case "skip": //num
                                counter += (int)parsenum(line[1]);
                                break;
                            case "break": //num
                                skipindentation(-(int)parsenum(line[1]));
                                break;
                            case "end": //
                                counter = lines.Length;
                                break;
                            case "subroutine": //pointer
                                if (pointers.ContainsKey(line[1]))
                                {
                                    linereturn.Add(counter);
                                    if (verbose == verbosity.runline)
                                        debugline("added " + counter + " to return stack");
                                    counter = pointers[line[1]] - 1;
                                    if (verbose == verbosity.runline)
                                        debugline("went to " + (counter+1));
                                }
                                else
                                    doerror(line[1] + " is not a defined pointer!");
                                break;
                            case "return": //
                                if (linereturn.Count == 0)
                                    doerror("there is nowhere to return to!");
                                else
                                {
                                    counter = linereturn[linereturn.Count - 1];
                                    if (verbose == verbosity.runline)
                                        debugline("returned to " + counter);
                                    linereturn.RemoveAt(linereturn.Count - 1);
                                }
                                break;
                            case "return_multi": //num
                                int repeats = (int)parsenum(line[1]);
                                int start = linereturn.Count - repeats;
                                if (start < 0)
                                    doerror("there is nowhere to return to! " + (-start) + " too many!");
                                else
                                {
                                    counter = linereturn[start];
                                    if (verbose == verbosity.runline)
                                        debugline("returned to " + counter);
                                    linereturn.RemoveRange(start, repeats);
                                }
                                break;
                            case "while": //bool
                                counter++; //go to indentor
                                if (parsebool(line[1]))
                                {
                                    linereturn.Add(counter-2); //sets return to line before this so it gets ran again when the loop returns
                                    if (verbose == verbosity.runline)
                                        debugline("added " + (counter-2) + " to return stack");
                                }
                                else
                                    skipindentation(0);
                                break;
                            case "goto_pointer": //pointer
                                counter = pointers[line[1]];
                                break;
                            //variable and internal and dynamic stuff
                            //okey that feels kinda cursed tbh
                            case "parse_bool": //bool var, string
                                setvar_bool(line[1], parsebool(parsestring(line[2])));
                                break;
                            case "parse_num": //num var, string
                                setvar_num(line[1], parsenum(parsestring(line[2])));
                                break;
                            case "parse_string": //string var, string
                                setvar_string(line[1], parsestring(parsestring(line[2])));
                                break;
                            case "parse_thing": //thing var, string
                                setvar_thing(line[1], parsething(parsestring(line[2])));
                                break;
                            case "set_dynamic_bool": //string, bool
                                setvar_bool(parsestring(line[1]), parsebool(line[2]));
                                break;
                            case "set_dynamic_num": //string, num
                                setvar_num(parsestring(line[1]), parsenum(line[2]));
                                break;
                            case "set_dynamic_string": //string, string
                                setvar_string(parsestring(line[1]), parsestring(line[2]));
                                break;
                            case "set_dynamic_thing": //string, thing
                                setvar_thing(parsestring(line[1]), parsething(line[2]));
                                break;
                            case "code_getline": //string var, num
                                {
                                    int lineindex = (int)parsenum(line[2]);
                                    if (lineindex >= lines.Length)
                                        doerror("negative line " + lineindex + " does not exist!");
                                    else
                                        setvar_string(line[1], lines[lineindex]);
                                }
                                break;
                            case "code_setline": //string, num
                                {
                                    int lineindex = (int)parsenum(line[2]);
                                    if (lineindex < 0)
                                        doerror("negative line " + lineindex + " does not exist!");
                                    else if (lineindex >= lines.Length)
                                        doerror(lineindex + " exceeds file length!");
                                    else
                                        lines[(int)parsenum(line[2])] = parsestring(line[1]);
                                }
                                break;
                            case "subroutine_dynamic": //string
                                {
                                    string pointername = parsestring(line[1]);
                                    if (pointers.ContainsKey(pointername))
                                    {
                                        linereturn.Add(counter);
                                        if (verbose == verbosity.runline)
                                            debugline("added " + counter + " to return stack");
                                        counter = pointers[pointername] - 1;
                                        if (verbose == verbosity.runline)
                                            debugline("went to " + (counter+1));
                                    }
                                    else
                                        doerror(pointername + " is not a defined pointer!");
                                }
                                break;
                            case "pointer_remove": //string
                                {
                                    string pointername = parsestring(line[1]);
                                    if (pointers.ContainsKey(pointername))
                                        pointers.Remove(pointername);
                                }
                                break;
                            case "pointer_getline": //num var, string
                                {
                                    string pointername = parsestring(line[2]);
                                    if (pointers.ContainsKey(pointername))
                                        setvar_num(line[1], pointers[pointername]);
                                    else
                                        doerror("pointer " + pointername + " doesn't exist!");
                                }
                                break;
                            case "pointer_define": //string, num
                                {
                                    string pointername = parsestring(line[1]);
                                    if (pointers.ContainsKey(pointername))
                                        doerror("pointer " + pointername + " was already defined as line " + pointers[pointername] + "!");
                                    else
                                        pointers.Add(pointername, (int)parsenum(line[2]));
                                }
                                break;

                            //add your program specific functions here
                            case "console_waitreadline": //string var
                                setvar_string(line[1], Console.ReadLine());
                                break;
                            case "console_write": //string
                                Console.Write(parsestring(line[1]));
                                break;
                            case "console_waitreadkey": //string var
                                setvar_string(line[1], Console.ReadKey(true).Key.ToString());
                                break;
                            case "debug_dumpdata": //
                                dumpdata();
                                break;
                            case "funnyimg_get": //thing var, num
                                {
                                    int refid = (int)parsenum(line[2]);
                                    if (refid >= funnyimages.Length)
                                        doerror("NOT EXIST FUNNY IMAGE!!");
                                    else
                                        setvar_thing(line[1], funnyimages[refid]);
                                }
                                break;
                            case "funnyimg_getstring": //string ref, thing
                                setvar_string(line[1], (string)parsething(line[2]));
                                break;
                            case "stopprogramrun": //
                                counter = lines.Length;
                                dorun = false;
                                break;
                        }
                    }
                    counter++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                dumpdata();
            }
        }
        static void doerror(string err, int linenumber = -8008135)
        {
            if (linenumber == -8008135)
                linenumber = counter;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(linenumber + ": " + err);
            Console.ResetColor();
        }
        static void dumpdata()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----DATA DUMP-----");
            Console.WriteLine("counter: " + counter);
            Console.WriteLine("boolean variables:");
            foreach (KeyValuePair<string, bool> entry in boolvars)
            {
                Console.WriteLine(entry.Key + " = " + entry.Value);
            }
            Console.WriteLine("number variables:");
            foreach (KeyValuePair<string, float> entry in numvars)
            {
                Console.WriteLine(entry.Key + " = " + entry.Value);
            }
            Console.WriteLine("string variables:");
            foreach (KeyValuePair<string, string> entry in stringvars)
            {
                Console.WriteLine(entry.Key + " = " + entry.Value);
            }
            Console.WriteLine("thing variables:");
            foreach (KeyValuePair<string, object> entry in thingvars)
            {
                Console.WriteLine(entry.Key + " = " + entry.Value.ToString());
            }
            Console.WriteLine("pointers:");
            foreach (KeyValuePair<string, int> entry in pointers)
            {
                Console.WriteLine(entry.Key + " sets to " + entry.Value);
            }
            Console.WriteLine("line return: " + string.Join(" | ", linereturn));
            Console.ResetColor();
        }
        static void debugline(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static void skipindentation(int indentationoffset)
        {
            int startingpos = counter;
            int indentationcount = 0;
            bool searching = true;
            if (verbose == verbosity.runline)
                debugline("searching for " + indentationoffset + " starting at " + counter);
            while (searching)
            {
                string trimmy = trimline(lines[counter]);
                if (trimmy == "{")
                    indentationcount++;
                else if (trimmy == "}")
                    indentationcount--;
                if (verbose == verbosity.runline)
                    debugline(counter + " | " + indentationcount);
                if (indentationcount == indentationoffset)
                    searching = false;
                else if (counter == lines.Length)
                {
                    doerror("indentation does not have a corresponding end!", startingpos);
                    searching = false;
                }
                else
                    counter++;
            }
        }
        static void run_hook(string hookname, params object[] stuff)
        {
            if (verbose == verbosity.runline)
                debugline("run hook " + hookname);
            if (pointers.ContainsKey(hookname))
            {
                counter = pointers[hookname];
                string[] line = seperateline(lines[counter].TrimStart());
                if (verbose == verbosity.runline)
                    debugline(counter + ": " + string.Join("|", line));
                isinhook = true;
                switch (line[0]) //add your hooks here
                {
                    case "#console_keypressed":
                        setvar_string(line[1], (string)stuff[0]);
                        break;
                }
                skipindentation(1); //search for start of hook function
                counter++;
                run();
            }
        }
        //line seperator
        static string[] seperateline(string line)
        {
            if (verbose == verbosity.seperateline)
                debugline(line);
            if (line == string.Empty || line.StartsWith("/") || line.StartsWith("{") || line.StartsWith("}") || line.StartsWith("else{"))
                return new string[0];
            List<string> linepieces = new List<string>();
            string curpiece = "";
            int rewritesection = 0; //0 = function, 1 = parameters, 2 = stringing
            bool nextliteral = false;
            for (int i = 0; i < line.Length; i++)
            {
                char curchar = line[i];
                if (verbose == verbosity.seperateline)
                    debugline(curchar + "|" + rewritesection + "|" + curpiece);
                if (nextliteral) //append next char, reset next literal
                {
                    if (curchar == 'n')
                        curpiece += "\n";
                    else
                        curpiece += curchar;
                    nextliteral = false;
                }
                else if (curchar == '\\') //set next character to be literal
                    nextliteral = true;
                else if (rewritesection == 0 && curchar == '(') //ends function name (add it to pieces and set as variable)
                {
                    linepieces.Add(curpiece);
                    curpiece = string.Empty;
                    rewritesection = 1;
                }
                else if (rewritesection == 0 && curchar == '/') //the same as running out of characters
                    break;
                else if (rewritesection == 1 && curchar == ')') //function name (add it to pieces and stop rewriting)
                {
                    linepieces.Add(curpiece);
                    curpiece = string.Empty;
                    break;
                }
                else if (rewritesection == 1 && curchar == ',') //end variable (add it to pieces)
                {
                    linepieces.Add(curpiece);
                    curpiece = string.Empty;
                }
                else if (rewritesection == 1 && curchar == '"') //start stringing
                {
                    curpiece = "\""; //so we know it's a plain string later on
                    rewritesection = 2;
                }
                else if (rewritesection == 2 && curchar == '"') //end stringing
                    rewritesection = 1;
                else if (rewritesection != 2 && char.IsWhiteSpace(curchar)) //ignore whitespace if not stringing
                    continue;
                else
                    curpiece += curchar;
            }
            if (curpiece != string.Empty)
                linepieces.Add(curpiece);
            if (verbose == verbosity.seperateline)
                debugline(string.Join("|", linepieces));
            return linepieces.ToArray();
        }
        static string trimline(string line)
        {
            return line.Trim().Split('/')[0]; //incase of comment and or whitespace
        }
        static float mod(float a, float b)
        {
            float mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm = a % b;
            if (mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm < 0f)
                return mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm + b;
            return mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm;
        }
        //variable handling
        static bool parsebool(string input)
        {
            if (verbose == verbosity.variables)
                debugline("parsebool " + counter + " | " + input);
            if (input == "_")
            {
                doerror("you cannot get a value from the discard!");
                return false;
            }
            else if (input == "true")
                return true;
            else if (input == "false")
                return false;
            else if (input.StartsWith("!"))
                return !parsebool(input.Substring(1)); //lol. lmao.
            else if (varexists_bool(input, out bool isprogram))
            {
                if (isprogram) //add your program variables here
                {
                    switch (input)
                    {
                        case "ISINHOOK":
                            return isinhook;
                        case "console_capslock":
                            return Console.CapsLock;
                        case "console_keyavailable":
                            return Console.KeyAvailable;
                        default:
                            doerror("you cannot read program boolean variable " + input + "!");
                            return false;
                    }
                }
                else
                    return boolvars[input];
            }
            else
                return false;
        }
        static float parsenum(string input)
        {
            if (verbose == verbosity.variables)
                debugline("parsenum " + counter + " | " + input);
            if (input == "_")
            {
                doerror("you cannot get a value from the discard!");
                return 0f;
            }
            else if (input == "PI")
                return (float)Math.PI;
            else if (float.TryParse(input.Replace(',', '.'), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float danumb))
                return danumb;
            else if (varexists_num(input, out bool isprogram))
            {
                if (isprogram) //add your program variables here
                {
                    switch (input)
                    {
                        case "PROGRAMVERSION":
                            return 2; //version of your program
                        case "IMPLEMENTATIONVERSION":
                            return 2; //version of fazfuck used as a base
                        case "COUNTER":
                            return counter;
                        default:
                            doerror("you cannot read program number variable " + input + "!");
                            return 0f;
                    }
                }
                else
                    return numvars[input];
            }
            else
                return 0f;
        }
        static string parsestring(string input)
        {
            if (verbose == verbosity.variables)
                debugline("parsestring " + counter + " | " + input);
            if (input == "_")
            {
                doerror("you cannot get a value from the discard!");
                return "";
            }
            else if (input.StartsWith("\""))
                return input.Substring(1);
            else if (varexists_string(input, out bool isprogram))
            {
                if (isprogram) //add your program variables here
                {
                    switch (input)
                    {
                        case "PROGRAMNAME":
                            return "baseconsole"; //name of your thing here
                        case "console_windowtitle":
                            return Console.Title;
                        default:
                            doerror("you cannot read program string variable " + input + "!");
                            return string.Empty;
                    }
                }
                else
                    return stringvars[input];
            }
            else
                return string.Empty;
        }
        static object parsething(string input)
        {
            if (verbose == verbosity.variables)
                debugline("parsething " + counter + " | " + input);
            if (input == "_")
            {
                doerror("you cannot get a value from the discard!");
                return -1;
            }
            else if (varexists_thing(input, out bool isprogram))
            {
                if (isprogram) //add your program variables here
                {
                    switch (input)
                    {
                        case "INVALID":
                            return null;
                        case "funnyimg_garfield":
                            return funnyimages[0];
                        default:
                            doerror("you cannot read program thing variable " + input + "!");
                            return null;
                    }
                }
                else
                    return thingvars[input];
            }
            else
                return -1;
        }
        static bool varexists_bool(string input, out bool isprogram, bool causeerror = true)
        {
            if (verbose == verbosity.variables)
                debugline("varexists_bool " + counter + " | " + input);
            isprogram = false;
            if (input.StartsWith("!"))
                return varexists_bool(input.Substring(1), out isprogram); //lol. lmao.
            if (progbools.Contains(input))
            {
                isprogram = true;
                return true;
            }
            if (boolvars.ContainsKey(input))
                return true;
            if (causeerror)
                doerror(input + " is not a valid boolean variable!");
            return false;
        }
        static bool varexists_num(string input, out bool isprogram, bool causeerror = true)
        {
            if (verbose == verbosity.variables)
                debugline("varexists_num " + counter + " | " + input);
            isprogram = false;
            if (prognums.Contains(input))
            {
                isprogram = true;
                return true;
            }
            if (numvars.ContainsKey(input))
                return true;
            if (causeerror)
                doerror(input + " is not a valid number variable!");
            return false;
        }
        static bool varexists_string(string input, out bool isprogram, bool causeerror = true)
        {
            if (verbose == verbosity.variables)
                debugline("varexists_string " + counter + " | " + input);
            isprogram = false;
            if (progstrings.Contains(input))
            {
                isprogram = true;
                return true;
            }
            if (stringvars.ContainsKey(input))
                return true;
            if (causeerror)
                doerror(input + " is not a valid string variable!");
            return false;
        }
        static bool varexists_thing(string input, out bool isprogram, bool causeerror = true)
        {
            if (verbose == verbosity.variables)
                debugline("varexists_thing " + counter + " | " + input);
            isprogram = false;
            if (progthings.Contains(input))
            {
                isprogram = true;
                return true;
            }
            if (thingvars.ContainsKey(input))
                return true;
            if (causeerror)
                doerror(input + " is not a valid thing variable!");
            return false;
        }
        static void setvar_bool(string input, bool value)
        {
            if (verbose == verbosity.variables)
                debugline("setvar_bool " + counter + " | " + input + " | " + value);
            if (input == "_")
                return;
            if (input.StartsWith("!"))
                setvar_bool(input.Substring(1), value);
            else if (progbools.Contains(input))
            {
                switch (input) //add your program variables here
                {
                    default:
                        doerror("you cannot modify program bool variable " + input + "!");
                        break;
                }
            }
            else if (varexists_bool(input, out _, false))
                boolvars[input] = value;
            else
                boolvars.Add(input, value);
        }
        static void setvar_num(string input, float value)
        {
            if (verbose == verbosity.variables)
                debugline("setvar_num " + counter + " | " + input + " | " + value);
            if (input == "_")
                return;
            if (prognums.Contains(input))
            {
                switch (input) //add your program variables here
                {
                    case "COUNTER":
                        counter = (int)value;
                        break;
                    default:
                        doerror("you cannot modify program number variable " + input + "!");
                        break;
                }
            }
            else if (varexists_num(input, out _, false))
                numvars[input] = value;
            else
                numvars.Add(input, value);
        }
        static void setvar_string(string input, string value)
        {
            if (verbose == verbosity.variables)
                debugline("setvar_string " + counter + " | " + input + " | " + value);
            if (input == "_")
                return;
            if (progstrings.Contains(input))
            {
                switch (input) //add your program variables here
                {
                    case "console_windowtitle":
                        Console.Title = value;
                        break;
                    default:
                        doerror("you cannot modify program string variable " + input + "!");
                        break;
                }
            }
            else if (varexists_string(input, out _, false))
                stringvars[input] = value;
            else
                stringvars.Add(input, value);
        }
        static void setvar_thing(string input, object value)
        {
            if (verbose == verbosity.variables)
                debugline("setvar_thing " + counter + " | " + input + " | " + value);
            if (input == "_")
                return;
            if (progthings.Contains(input))
            {
                switch (input) //add your program variables here
                {
                    default:
                        doerror("you cannot modify program thing variable " + input + "!");
                        break;
                }
            }
            else if (varexists_thing(input, out _, false))
                thingvars[input] = value;
            else
                thingvars.Add(input, value);
        }
    }
}
