enum ServicingStatus {
  initial,
  pendingReview,
  pendingPayment,
  pendingServicing,
  completed,
  cancelled
}

extension Name on ServicingStatus {
  String getName() {
    return "${name.substring(0, 1).toUpperCase()}${name.substring(1)}";
  }
}
