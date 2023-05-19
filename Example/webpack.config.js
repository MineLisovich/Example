"use strict";

module.exports = {
    entry: "./src/file.js",
    output: {
        filename: "./dist/bundle.js"
    },
    devServer: {
        contentBase: ".",
        host: "localhost",
        port: 44392
    },
    module: {
        loaders: [
            {
                test: /\.jsx?$/,
                loader: "babel-loader"
            }
        ]
    }
};