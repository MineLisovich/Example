"use strict"
{
    // ��������� ��� ������������ ������� output ����
    let path = require('path');

    // ������ ��� ������� �������� ����� (bundle) ����� ��������� �����
    const CleanWebpackPlugin = require('clean-webpack-plugin');

    // ���� � �������� �����
    const bundleFolder = "wwwroot/bundle/";

    module.exports = {
        // ����� ����� � ����������
        entry: path.resolve(__dirname, 'wwwroot') + '/js/main.js',  
        // �������� ����
        output: {
            filename: 'script.min.js',
            path: path.resolve(__dirname, bundleFolder)
        },
        plugins: [
            new CleanWebpackPlugin([bundleFolder])
        ]
    };
}