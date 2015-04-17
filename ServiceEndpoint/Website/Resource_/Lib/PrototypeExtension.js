/** Excerpt from Themelia Pro - Client Module  **/
/**   Copyright (c) 2008-2009 David Betz [MVP] (http://www.netfxharmonics.com/) **/
Namespace = window.Namespace || {};
Namespace.create = function(ns, separator) {
    var parts = ns.split(separator || '.');
    var nsObj = window;
    var count = parts.length;
    for (var i = 0; i < count; i++) {
        nsObj[parts[i]] = nsObj[parts[i]] || {};
        nsObj = nsObj[parts[i]];
    }
};
//+
Enum = Namespace;