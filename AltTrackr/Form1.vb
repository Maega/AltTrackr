Imports EO.WebBrowser

Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public fiats() As String = {"btc", "usd", "gbp", "eur", "chf", "cny", "jpy", "cad", "aud", "rub", "sek", "hkd", "sgd", "twd", "krw", "zar", "inr", "myr", "idr", "brl", "nzd", "mxn", "php", "dkk", "pln", "xau", "xag", "xdr"}
    Public coins() As String = {"apexcoin", "archcoin", "adzcoin", "aeon", "agoras", "aidbit", "aiden", "ambercoin", "amsterdamcoin", "anoncoin", "antshares", "applecoin", "arcade-token", "arcticcoin", "ardor", "argentum", "ark", "artbyte", "artex-coin", "asch", "asiacoin", "asiadigicoin", "audiocoin", "augur", "auroracoin", "btsr", "bankcoin", "bata", "Beatcoin", "belacoin", "benjirolls", "bikercoin", "bipcoin", "bitbay", "bitcrystals", "bitsend", "bitshares", "bitstake", "bitswift", "bitusd", "bitzeny", "bitbar", "bitbean", "bitcedi", "bitcoin", "bitcoin-plus", "bitcoin-scrypt", "bitcoindark", "bitcoin-ultra", "bitconnect", "bitgem", "bitland", "bitleu", "bitmark", "bitparkcoin", "bitstar", "bitz", "blackcoin", "blakecoin", "blitzcash", "blockpay", "blockshares", "blocknet", "bluecoin", "boolberry", "boostcoin", "bottlecaps", "breakout", "breakout-stake", "britcoin", "burst", "byteball", "bytecent", "bytecoin", "cabbage-unit", "cagecoin", "caliphcoin", "canada-ecoin", "cannabis-industry-coin", "cannabiscoin", "cannacoin", "capricoin", "casinocoin", "centurion", "cerium", "chaincoin", "chronobank", "cinni", "circuits-of-value", "clams", "cloakcoin", "clubcoin", "coin2-1", "coinomat", "comet", "counterparty", "crave", "creditbit", "crevacoin", "crowncoin", "cryptcoin", "crypto", "cryptobullion", "cryptocarbon", "cryptoescudo", "cryptojacks", "cryptokenz", "cryptonite", "curecoin", "dnotes", "darcrus", "dash", "dashcoin", "debune", "decred", "deutsche-emark", "devcoin", "diamond", "digicube", "digieuro", "digibyte", "digitalnote", "digitalcoin", "digixdao", "dirac", "dobbscoin", "dogecoin", "dogeparty", "dopecoin", "dotcoin", "dubaicoin", "dubaicoin-dbix", "e-dinar-coin", "edrcoin", "earthcoin", "edgeless", "einsteinium", "elcoin", "electronicgulden", "elektron", "emercoin", "energycoin", "espers", "ethereum", "ethereum-classic", "evergreencoin", "exclusivecoin", "execoin", "expanse", "fimkrypto", "factom", "faircoin", "fantomcoin", "fastcoin", "feathercoin", "fedoracoin", "fibre", "first-bitcoin", "first-blood", "fitcoin", "florincoin", "flycoin", "foldingcoin", "franko", "freicoin", "freshcoin", "fuelcoin", "full-integrity-coin", "gaia", "gcoin", "gsmcoin", "gambit", "gamebetcoin", "gamecredits", "gems", "geocoin", "global-currency-reserve", "globalboost", "glowshares", "gnosis", "goldblocks", "goldcoin", "goldmaxcoin", "golem", "golos", "granitecoin", "grantcoin", "gridcoin-research", "groestlcoin", "groupcoin", "guarany", "gulden", "heat", "hodlcoin", "htmlcoin", "hacker-gold", "hamradiocoin", "heavycoin", "hellascoin", "hicoin", "hitcoin", "hobonickels", "horizon", "humaniq", "huntercoin", "hyper", "hyperstake", "openledger", "iocoin", "ion", "iconomi", "incent", "infinitecoin", "influxcoin", "insanecoin", "ixcoin", "janus", "jinn", "jobscoin", "joincoin", "judgecoin", "karbowanec", "karma", "kashhcoin", "khancoin", "komodo", "korecoin", "krypton", "kurrent", "kushcoin", "lbry-credits", "leocoin", "ltbcoin", "lepen", "libertycoin", "librexcoin", "lisk", "litedoge", "litecoin", "litecoindark", "lomocoin", "luckchain", "luckycoin", "lunacoin", "lykke", "mbitbooks", "mmnxt", "mayacoin", "magi", "maidsafecoin", "mangocoinz", "mapcoin", "marinecoin", "martexcoin", "maryjane", "master-swiscoin", "mastertradercoin", "mastercoin", "maxcoin", "mazacoin", "megacoin", "melon", "metal-music-coin", "mincoin", "mineralscoin", "mintcoin", "moin", "mojocoin", "monacoin", "monero", "monetaryunit", "monocle", "mooncoin", "muse", "musicoin", "myriadcoin", "nav-coin", "nem", "nxt", "nxtventure", "namecoin", "nautiluscoin", "neoscoin", "neptunecoin", "netcoin", "neucoin", "nexium", "nexus", "noblecoin", "node", "novacoin", "nubits", "nushares", "nxttyacci", "nxttycoin", "nyancoin", "obits", "okcash", "octocoin", "omnicoin", "opal", "orbitcoin", "pivx", "prcoin", "pakcoin", "pandacoin", "pangea-poker", "parkbyte", "pascalcoin", "paycoin", "peercoin", "peerplays", "pepecash", "pesobit", "philosopherstone", "phoenixcoin", "piggycoin", "pinkdog", "pinkcoin", "pipcoin", "posw-coin", "positron", "potcoin", "primecoin", "prizm", "project-decorum", "purevidz", "putincoin", "qibuck", "qora", "quark", "quatloo", "quazarcoin", "qwark", "radium", "ratecoin", "razor", "reddcoin", "renos", "revolvercoin", "riecoin", "rimbit", "ripple", "rise", "round", "rubycoin", "sarcoin", "sibcoin", "soilcoin", "safe-exchange-coin", "salus", "sativacoin", "scotcoin", "secretcoin", "sequence", "sexcoin", "shadowcash", "shibecoin", "shift", "shilling", "siacoin", "singulardtv", "smartcoin", "socialxbot", "solarflarecoin", "solarcoin", "sonicscrewdriver", "spectrecoin", "spreadcoin", "sprouts", "startcoin", "stealthcoin", "steem", "steem-dollars", "lumens", "steps", "sterlingcoin", "storjcoinx", "stratis", "stress", "supercoin", "supernet", "swagbucks", "swarm-city", "swing", "swiscoin", "sync", "synereo", "synergy", "syscoin", "tacocoin", "tagcoin", "tao", "tattoocoin-limited", "tattoocoin", "techcoin", "terracoin", "teslacoin", "tether", "dao", "thegcccoin", "tilecoin", "titcoin", "tittiecoin", "tokencard", "torcoin", "transfercoin", "triggers", "trollcoin", "truckcoin", "trumpcoin", "trustplus", "ufocoin", "usde", "ubiq", "ucoin", "ultracoin", "unbreakablecoin", "unioncoin", "unitus", "unobtanium", "uro", "utacoin", "utilitycoin", "vpncoin", "vcash", "veltor", "verge", "vericoin", "veriumreserve", "veros", "vertcoin", "viacoin", "virtacoinplus", "virtualcoin", "visio", "vootcoin", "voxels", "wmcoin", "wankcoin", "waves", "wetrust", "wexcoin", "whitecoin", "wild-beast-block", "wings", "woodcoin", "worldcoin", "xcoin", "xaurum", "xenixcoin", "xiaomicoin", "xtrabytes", "yashcoin", "ybcoin", "yogold", "yocoin", "zcoin", "zccoin", "zcash", "zclassic", "zeitcoin", "zetacoin", "zonecoin", "bitCNY", "iexec-rlc", "jl777hodl", "vslice", "vtorrent", "xcash", "ziftrcoin"}
    Public widgetURL As String = "https://www.coingecko.com/en/widget_component/ticker/"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'You'll need a license for EO.WebBrowser 17.1.65 (unless updated - downgrading seems to break things) to remove the message that appears when the library is loaded.
        'EO.WebBrowser.Runtime.AddLicense("")

        Me.Location = New Point(My.Settings.appLocationX, My.Settings.appLocationY)

        Me.Width = My.Settings.appWidth
        Me.Height = My.Settings.appHeight
        webView.LoadUrl(widgetURL + My.Settings.tickerCoin + "/" + My.Settings.tickerFiat)

        'Attach event handlers
        AddHandler webView.BeforeContextMenu, New BeforeContextMenuHandler(AddressOf WebView_BeforeContextMenu)
        AddHandler webView.Command, New CommandHandler(AddressOf nRef_Command)
        AddHandler webView.NewWindow, New NewWindowHandler(AddressOf WebView_NewWindow)

        Me.Opacity = My.Settings.appOpacity
        tmrRefresh.Interval = My.Settings.tickerInterval

        If My.Settings.appTaskbarIcon = True Then
            ShowInTaskbar = True
        ElseIf My.Settings.appTaskbarIcon = False Then
            ShowInTaskbar = False
        End If

    End Sub


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles webControl.MouseDown, Me.MouseDown, webView.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles webControl.MouseMove, Me.MouseMove, webView.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles webControl.MouseUp, Me.MouseUp, webView.MouseUp
        drag = False
    End Sub

    Dim nPrefCommand As Integer = CommandIds.RegisterUserCommand("Preferences...")
    Dim nTaskIconCommand As Integer = CommandIds.RegisterUserCommand("Toggle Taskbar Icon")
    Dim nExitCommand As Integer = CommandIds.RegisterUserCommand("Quit")

    Private Sub nRef_Command(sender As Object, e As CommandEventArgs)
        Dim webView As WebView = DirectCast(sender, WebView)
        If e.CommandId = nPrefCommand Then
            frmPreferences.Show()
        ElseIf e.CommandId = nExitCommand Then
            Application.Exit()
        ElseIf e.CommandId = nTaskIconCommand Then
            If My.Settings.appTaskbarIcon = True Then
                My.Settings.appTaskbarIcon = False
                Me.ShowInTaskbar = False
            ElseIf My.Settings.appTaskbarIcon = False Then
                My.Settings.appTaskbarIcon = True
                Me.ShowInTaskbar = True
            End If
            My.Settings.Save()
        End If
    End Sub

    'Build a custom context menu in the event handler
    Private Sub WebView_BeforeContextMenu(sender As Object, e As BeforeContextMenuEventArgs)
        e.Menu.Items.Clear()
        e.Menu.Items.Add(New EO.WebBrowser.MenuItem("Refresh Now", CommandIds.Reload))
        e.Menu.Items.Add(New EO.WebBrowser.MenuItem("Preferences...", nPrefCommand))
        e.Menu.Items.Add(New EO.WebBrowser.MenuItem("Toggle Taskbar Icon", nTaskIconCommand))
        e.Menu.Items.Add(EO.WebBrowser.MenuItem.CreateSeparator())
        e.Menu.Items.Add(New EO.WebBrowser.MenuItem("Quit", nExitCommand))
    End Sub

    Private Sub WebView_NewWindow(sender As Object, e As NewWindowEventArgs)
        'Below signifies that we accept the new WebView. Without this line
        'the newly created WebView will be immediately destroyed...
        'e.Accepted = True
        Process.Start(e.TargetUrl)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.appLocationX = CInt(Me.Location.X)
        My.Settings.appLocationY = CInt(Me.Location.Y)
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        webView.Reload()
    End Sub
End Class
