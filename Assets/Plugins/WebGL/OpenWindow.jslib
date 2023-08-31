var playPlugin = {
    HTMLButtonPlugin: function()
    {
        var a = document.getElementById("play-btn");
        a.style.display = "flex";

        var b = document.getElementById("pause-btn");
        b.style.display = "flex";
        
    }
};

var URLPlugin = {
    AgumentedReality: function() 
    {
        window.location.assign("https://theintellify.com/augmented-reality/");
    },

    EnterpriseMobility: function() 
    {
        window.location.assign("https://theintellify.com/enterprise-mobility/");
    },

    VirtualReality: function() 
    {
        window.location.assign("https://theintellify.com/virtual-reality-app-development/");
    },

    ContactUs: function() 
    {
        window.location.assign("https://www.theintellify.com/contact/");
    },

    Website: function() 
    {
        window.location.assign("https://theintellify.com");
    }
};

mergeInto(LibraryManager.library, playPlugin);
mergeInto(LibraryManager.library, URLPlugin);