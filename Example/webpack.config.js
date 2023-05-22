"use strict"
{
    // Требуется для формирования полного output пути
    let path = require('path');

    // Плагин для очистки выходной папки (bundle) перед созданием новой
    const CleanWebpackPlugin = require('clean-webpack-plugin');

    // Путь к выходной папке
    const bundleFolder = "wwwroot/bundle/";

    module.exports = {
        // Точка входа в приложение
        entry: path.resolve(__dirname, 'wwwroot') + '/js/main.js',  
        // Выходной файл
        output: {
            filename: 'script.min.js',
            path: path.resolve(__dirname, bundleFolder)
        },
        plugins: [
            new CleanWebpackPlugin([bundleFolder])
        ]
    };
}