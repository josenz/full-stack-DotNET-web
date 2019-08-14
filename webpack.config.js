const path = require('path');

module.exports = {
    mode: 'development',
    entry: {'main': './wwwroot/source/app.js'}, // The main property here is for Hotmodule because it does require a "main" entry point in the output settings.
    output: {
        path: path.resolve(__dirname, 'wwwroot/dist'),
        filename: 'bundle.js',
        publicPath: 'dist/'
    },
    module: {
        rules: [
            {
                test: /\.jsx?$/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-react' ,'@babel/preset-env']
                    }
                }
            }
        ]
    }
};