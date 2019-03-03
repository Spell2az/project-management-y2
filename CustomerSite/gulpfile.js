/// <binding ProjectOpened='default' />
const gulp = require('gulp');
const sass = require('gulp-sass');

var bootstrapSass = {
    in: './node_modules/bootstrap/scss/'
};

var scss = {
    in: 'src/scss/main.scss',
    out: 'src/css/',
    watch: 'src/scss/**/*',
    sassOpts: {
        outputStyle: 'nested',
        precison: 3,
        errLogToConsole: true,
        includePaths: [bootstrapSass.in]
    }
};

const js = () => {
    return gulp.src([
            'node_modules/bootstrap/dist/js/bootstrap.min.js', 'node_modules/jquery/dist/jquery.min.js',
            'node_modules/popper.js/dist/umd/popper.min.js'
        ])
        .pipe(gulp.dest("src/js"));
}

const style = () => {

    return (
        gulp
            .src(scss.in)
            .pipe(sass(scss.sassOpts))
            .on("error", sass.logError)
            .pipe(gulp.dest(scss.out))
    );
}

exports.default = gulp.parallel(js,
    style,
    () => {
        gulp.watch(scss.watch, style);
    });
