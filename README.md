# A Repository for Reproducing a Bug in ReactiveUI

When a view model is changed for a `ViewModelViewHost`,
it creates the old view again and only after that creates a new view,
which causes brief flickering of views.
