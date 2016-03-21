﻿namespace GeneCms.Ui.Eto.Wpf
module Program =

    open System
    open GeneCms.Ui.Eto

    [<EntryPoint>]
    [<STAThread>]
    let Main(args) = 
        let app = new Eto.Forms.Application(Eto.Platform.Detect)
        app.Run(new MainForm())
        0